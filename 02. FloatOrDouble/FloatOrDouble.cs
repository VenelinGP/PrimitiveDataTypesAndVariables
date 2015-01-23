using System;
/*
 * Which of the following values can be assigned to a variable of type  float  and 
 * which to a variable of type  double :  34.567839023, 12.345, 8923.1234857, 3456.091 ?
 * Write a program to assign the numbers in variables and print them to ensure no precision is lost.
 */
class FloatOrDouble
{
    static void Main()
    {
        double firstVar = 34.567839023;
        float secondVar = 12.345F;
        double thirdVar = 8923.1234857;
        float fourthVar = 3456.091F;
        Console.WriteLine("{0} and {1} are \"double\" type",firstVar, thirdVar);
        Console.WriteLine("and {0} and {1} are \"float\" type", secondVar, fourthVar);
    }
}
