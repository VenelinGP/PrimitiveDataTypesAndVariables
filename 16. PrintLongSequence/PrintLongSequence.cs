using System;

// Write a program that prints the first 1000 members of the sequence:  2, -3, 4, -5, 6, -7, … 

class PrintLongSequence
{
    static void Main()
    {
        for (int i = 2; i <= 1000; i += 2)
        {
            Console.Write(i + ", ");
            Console.Write(-i - 1 + ", ");
        }
        Console.WriteLine();
    }
}
