using System;

namespace DuetDiscordNotification.Config
{
    public enum PrinterStatus
    {
        Unknown, //U
        Idle,   //I
        Printing, //P
        Error, //E
        Flashing, //F
        Paused, //D
        Busy, //B
        Halted // H
    }


    public static class PrinterStatusMethods
    {
        public static String GetString(this PrinterStatus status)
        {
            string result = "Unknown";
            switch (status)
            {
                case PrinterStatus.Unknown:
                    result = "Unknown";
                    break;
                case PrinterStatus.Idle:
                    result = "Idle";
                    break;
                case PrinterStatus.Printing:
                    result = "Printing";
                    break;
                case PrinterStatus.Error:
                    result = "Error";
                    break;
                case PrinterStatus.Flashing:
                    result = "Flashing";
                    break;
                case PrinterStatus.Paused:
                    result = "Paused";
                    break;
                case PrinterStatus.Busy:
                    result = "Busy";
                    break;
                case PrinterStatus.Halted:
                    result = "Halted";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(status), status, null);
            }

            return result;
        }

        public static PrinterStatus GetCurrentStatus(string state)
        {
            PrinterStatus statusValue = PrinterStatus.Unknown;
            if ("IC".Contains(state))
            {
                statusValue = PrinterStatus.Idle;
            }
            if ("F".Contains(state))
            {
                statusValue = PrinterStatus.Flashing;
            }
            else if ("PTM".Contains(state))
            {
                statusValue = PrinterStatus.Printing;
            }

            return statusValue;
        }

    }

}
