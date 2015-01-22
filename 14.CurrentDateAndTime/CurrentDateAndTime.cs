using System;

// Create a console application that prints the current date and time. Find out how in Internet

class CurrentDateAndTime
{
    static void Main()
    {
        System.DateTime nowDateTime = DateTime.Now;
        Console.WriteLine(nowDateTime);
        Console.WriteLine("The date is " + nowDateTime.ToLongDateString());
        Console.WriteLine("The time is " + nowDateTime.ToString("HH:mm"));
    }

}