// .NET 6
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace StripperDates
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath = @"C:\Users\lawson\Desktop\StripperDates.txt";

            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            DateOnly plus85 = today.AddDays(85);
            DateOnly plus180 = today.AddDays(180);
            DateOnly plus365 = today.AddDays(365);
            DateOnly plus364 = today.AddDays(364);

            string todayString = today.ToString();
            string plus85String = plus85.ToString();
            string plus180String = plus180.ToString();
            string plus364String = plus364.ToString();
            string plus365String = plus365.ToString();

            string line0 = "\n";
            string line1 = "Today is " + todayString + ".";
            string line2 = "FREESTYLE LIBRE must expire AFTER: " + plus85String + ".";
            string line3 = "ALL OTHER BOXES:";
            string line4 = "FULL PRICE if expiring AFTER: " + plus365String + ".";
            string line5 = "HALF PRICE if expiring BETWEEN: " + plus180String + " and " + plus364String + ".";
            string line6 = "This is the date-based pricing.";
            string line7 = "This is the MAXIMUM we could pay for MINT CONDITION boxes based on the dates.";
            string line8 = "But all boxes must still be graded for condition and adjustments to price should be expected.";
            
            string[] lines = new string[] { line1, line0, line2, line0, line3, line0, line4, line0, line5, line0, line6, line0, line7, line0, line8 };

            void WriteIt()
            {
                File.WriteAllLines(filePath, lines);
                return;
            }
            WriteIt();
        }
    }
}