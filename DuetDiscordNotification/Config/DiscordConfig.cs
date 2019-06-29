
namespace DuetDiscordNotification.Config
{
    public class DiscordConfig
    {
        public string APIKey { get; set; }

        private bool _connected = false;

        public void SendMessage(string msg)
        {
            if (!_connected)
            {
                Connect();
            }


        }

        private void Connect()
        {
            
        }

    }
}
