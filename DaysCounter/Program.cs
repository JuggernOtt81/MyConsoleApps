// .NET 6
global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        DateOnly today = DateOnly.FromDateTime(DateTime.Now);
        DateOnly born = new DateOnly(1981, 01, 20);
        DateOnly hire = new DateOnly(2017, 01, 20);

        string todayString = today.ToString();
        string hireString = hire.ToString();
        string bornString = born.ToString();

        var employedDays = today.DayOfYear - hire.DayOfYear;
        var employedYears = today.Year - hire.Year;
        var aliveDays = today.DayOfYear - born.DayOfYear;
        var aliveYears = today.Year - born.Year;
        decimal totalEmployedDays = (decimal)(employedYears * 365.2425 + employedDays);
        decimal totalAliveDays = (decimal)(aliveYears * 365.2425 + aliveDays);
        decimal totalEmployedDaysDecimal = totalEmployedDays;
        decimal totalAliveDaysDecimal = totalAliveDays;
        decimal percentage = totalEmployedDaysDecimal / totalAliveDaysDecimal * 100;

        Console.WriteLine("Today is " + todayString + ".");
        Console.WriteLine(" ");
        Console.WriteLine("I started \"THIS JOB\" on " + hireString + ".");
        Console.WriteLine("I have worked here for " + employedYears + " years & " + employedDays + " days. (" + (int)totalEmployedDays + " days total)");
        Console.WriteLine(" ");
        Console.WriteLine("I was born on " + bornString + ".");
        Console.WriteLine("I have been alive for " + aliveYears + " years & " + aliveDays + " days. (" + (int)totalAliveDays + " days total)");
        Console.WriteLine(" ");
        Console.WriteLine("I have spent " + Convert.ToDecimal(string.Format("{0:F2}", percentage)) + "% of my life in this job.");

        Console.ReadLine();
    }
}