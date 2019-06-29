using System;

namespace DuetDiscordNotification.Config
{
    public enum PrinterStatus
    {
        Unknown, //U
        Idle,   //I
        Printing, //P
        Error //E
    }


    public static class PrinterStatusMethods
    {
        public static String GetString(this PrinterStatus status)
        {
            switch (status)
            {
                case PrinterStatus.Unknown:
                    return "Unknown";
                    break;
                case PrinterStatus.Idle:
                    return "Idle";
                    break;
                case PrinterStatus.Printing:
                    return "Printing";
                    break;
                case PrinterStatus.Error:
                    return "Error";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }
        }

        public static PrinterStatus GetCurrentStatus(string state)
        {
            PrinterStatus statusValue = PrinterStatus.Unknown;
            if (state == "I")
            {
                statusValue = PrinterStatus.Idle;
            }
            else if (state == "P")
            {
                statusValue = PrinterStatus.Printing;
            }

            return statusValue;
        }

    }

}
