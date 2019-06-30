using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace DuetDiscordNotification.Messages
{
    public class DiscordMessage
    {
        [JsonProperty("username")]
        public string username { get; set; }
        [JsonProperty("content")]
        public string content { get; set; }
    }
}
