using System;

// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class AgeAfter10Years
{
    static void Main()
    {
        Console.Write("When were you born? ");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime today = DateTime.Today;
        int age;
        int didYouHaveABirthDay;
        if (today.DayOfYear - birthday.DayOfYear < 0)
           {
               didYouHaveABirthDay = 1;
           }
        else
           {
                didYouHaveABirthDay = 0;
           }
        age = today.Year - birthday.Year - didYouHaveABirthDay;
        Console.WriteLine("Your age is {0} and after 10 years you will be {1}", age, age + 10);
    }
}