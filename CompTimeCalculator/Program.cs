using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompTimeCalculator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        //
        // Calculate functions
        //
        static public TimeSpan TimeDifference(DateTime startTime, DateTime endTime)
        {
            DateTime startDate;
            DateTime endDate;

            if (GetMeridiem(startTime) == "PM" && GetMeridiem(endTime) == "AM"
                || (GetMeridiem(startTime) == GetMeridiem(endTime) && endTime < startTime))
            {
                // Crossed date boundary
                startDate = new DateTime(0001, 01, 01, startTime.Hour, startTime.Minute, 00);
                endDate = new DateTime(0001, 01, 02, endTime.Hour, endTime.Minute, 00);
            }
            else
            {
                // Did not cross data boundary
                startDate = new DateTime(0001, 01, 01, startTime.Hour, startTime.Minute, 00);
                endDate = new DateTime(0001, 01, 01, endTime.Hour, endTime.Minute, 00);
            }

            return endDate.Subtract(startDate);
        }

        static public double TruncateWithTwoDecimalPlaces(double dbl)
        {
            // Only consider whole minutes. Seconds are truncated.
            return Math.Round(dbl - 0.005, 2);
        }

        //
        // Conversion functions
        //
        static public double ToDecimalHour(TimeSpan ts)
        {
            int hours = ts.Hours;
            double minutes = ts.Minutes / 60.0;

            return hours + minutes;
        }

        static public double ToDecimalHour(DateTime dt)
        {
            int hours = dt.Hour;
            double minutes = dt.Minute / 60.0;

            return hours + minutes;
        }

        static public TimeSpan ToTimeSpan(double time)
        {
            int hours = (int)time;
            double fractional = time - hours;
            int minutes = (int)(fractional * 60);

            return new TimeSpan(hours, minutes, 0);
        }

        static public string ToString(TimeSpan timespan)
        {
            return timespan.Hours.ToString("00") + ":" + timespan.Minutes.ToString("00");
        }

        static public string ToString(double decimalTime)
        {
            return Math.Round(decimalTime, 2).ToString("0.00"); ;
        }

        //
        // Getter functions
        //
        static private string GetMeridiem(DateTime time)
        {
            string temp = time.ToString("tt", System.Globalization.CultureInfo.InvariantCulture); ;
            return temp;
        }
    }
}
