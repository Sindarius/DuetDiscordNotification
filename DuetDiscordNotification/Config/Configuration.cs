using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace DuetDiscordNotification.Config
{
    public class Configuration
    {

        public const string ConfigFile = @"C:\Users\Public\DuetDiscordNotification\config.json";

        public List<Printer> Printers { get; set; }

        public Configuration()
        {

        }

        public static Configuration Load()
        {
            Configuration config = null;
            if (System.IO.File.Exists(ConfigFile))
            {
                using (StreamReader reader = new StreamReader(ConfigFile))
                {
                    var serializedConfig = reader.ReadToEnd();
                    config = JsonConvert.DeserializeObject<Configuration>(serializedConfig, new JsonSerializerSettings() { MissingMemberHandling = MissingMemberHandling.Ignore });
                }
            }
            else
            {
                var path = System.IO.Path.GetDirectoryName(@"C:\Users\Public\DuetDiscordNotification\config.json");
                //Check if the directory already exists
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                config = new Configuration
                {
                    Printers = new List<Printer>(),
                };
                config.Save();
            }

            return config;
        }
        public void Save()
        {
            var seralizedConfig = JsonConvert.SerializeObject(this);
            System.IO.File.WriteAllText(ConfigFile, seralizedConfig);
        }

        public Printer NewPrinter()
        {
            var newPrinter = new Printer();
            Printers.Add(newPrinter);
            return newPrinter;
        }

        public void DeletePrinter(Printer printer)
        {
            Printers.Remove(printer);
        }


    }
}
