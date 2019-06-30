using DuetDiscordNotification.Messages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace DuetDiscordNotification.Config
{

    public class Printer
    {

        public bool Active { get; set; } = false;
        public string Name { get; set; } = "New Printer";
        public string IPAddress { get; set; }
        public string Webhook { get; set; }

        [JsonIgnore]
        public PrinterStatus PrinterStatus { get; set; } = PrinterStatus.Unknown;

        [JsonIgnore] public double LastReportedPercent = -1;

        [JsonIgnore] public string CurrentFileName;


        private HttpClient _client;



        public void UpdatePrinterStatus()
        {
            if (!Active) { return; }
            if (IPAddress == null) { return; }

            if (string.IsNullOrEmpty(Webhook)) { return; }

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    //Check printer status
                    var duetStatusRequest = GetStatus(client);

                    //Check printer state. if it has changed then we'll send a message to discord.
                    var duetStatus = PrinterStatusMethods.GetCurrentStatus(duetStatusRequest.Status);

                    //The status has changed
                    if (duetStatus != PrinterStatus)
                    {
                        SendMessage($"Status has changed from {PrinterStatus.GetString()} to {duetStatus.GetString()}");
                        PrinterStatus = duetStatus;

                        if (PrinterStatus == PrinterStatus.Printing)
                        {
                            GetFileInfo(client);
                            LastReportedPercent = 0;
                            SendMessage($"Printing {CurrentFileName}");
                        }

                    }

                    //Check printer Percentage.
                    if (PrinterStatus == PrinterStatus.Printing)
                    {
                        var increment = (int)duetStatusRequest.FractionPrinted / 10; //We'll start with 10% increments and eventually make this configurable
                        if (increment > LastReportedPercent)
                        {
                            SendMessage($"Print is currently at {increment * 10}%");
                            LastReportedPercent = increment;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                PrinterStatus = PrinterStatus.Unknown; //May be disconnected or missed messages
                                                       //There was an error communicating with the printer.
            }
        }

        public DuetStatusResponse GetStatus(HttpClient client)
        {
            var result = client.GetStringAsync($"http://{IPAddress}/rr_status?type=3");
            var printerJson = result.Result;
            var duetMessage = JsonConvert.DeserializeObject(printerJson, typeof(DuetStatusResponse), new JsonSerializerSettings { MissingMemberHandling = MissingMemberHandling.Ignore }) as DuetStatusResponse;
            return duetMessage;
        }

        public void GetFileInfo(HttpClient client)
        {
            var fileResult = client.GetStringAsync($"http://{IPAddress}/rr_fileinfo");
            var fileResultJson = fileResult.Result;
            var fileMessage = JsonConvert.DeserializeObject(fileResultJson, typeof(DuetFileResponse)) as DuetFileResponse;
            CurrentFileName = fileMessage.FileName;
        }

        public void SendMessage(string msg)
        {
            using (HttpClient discordClient = new HttpClient())
            {
                DiscordMessage message = new DiscordMessage
                {
                    content = msg
                };
                var json = JsonConvert.SerializeObject(message);

                var buffer = System.Text.Encoding.UTF8.GetBytes(json);
                var content = new ByteArrayContent(buffer);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var result = discordClient.PostAsync(Webhook, content).Result;
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
