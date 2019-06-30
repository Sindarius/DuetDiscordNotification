using Newtonsoft.Json;

namespace DuetDiscordNotification.Messages
{
    public class DuetFileResponse
    {
        [JsonProperty("height")]
        public double Height { get; set; }

        [JsonProperty("layerHeight")]
        public double LayerHeight { get; set; }

        [JsonProperty("printTime")]
        public double PrintTime { get; set; }

        [JsonProperty("printDuration")]
        public double PrintDuration { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

    }
}
