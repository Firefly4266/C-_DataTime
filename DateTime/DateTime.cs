using System;

public class Date_Time
{
    public static void Main(string[] args)
    {
        var dateTime = new DateTime(1965, 04, 18);
        var now = DateTime.Now;
        var today = DateTime.Today;
        Console.WriteLine("Hour:" + now.Hour);
        Console.WriteLine("minute: " + now.Minute);

        var tomorrow = now.AddDays(1);
        var yesterday = dateTime.AddDays(-1);
        Console.WriteLine(tomorrow);
        Console.WriteLine(yesterday);

        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString());
        Console.WriteLine(now.ToString("yyyy-MM-dd"));
        Console.WriteLine(now.ToString("HH-mm"));
    }
}