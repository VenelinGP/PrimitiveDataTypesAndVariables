using System;

// Write a program that prints the first 10 members of the sequence:  2, -3, 4, -5, 6, -7, ...  

class PrintASequence
{
    static void Main()
    {
        for (int i = 2; i <= 10; i += 2)
        {
            Console.Write(i + ", ");
            Console.Write(-i - 1 + ", ");
        }
        Console.WriteLine();
    }
}
