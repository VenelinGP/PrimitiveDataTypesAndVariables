using System;

/*Create a program that assigns null values to an integer and to a double variable. 
 * Try to print these variables at the console. 
 * Try to add some number or the null literal to these variables and print the result.
 */

class NullValuesArithmetic
    {
        static void Main()
        {
            int? intVar = null;
            double? doubleVar = null;
            Console.WriteLine("Integer Variable = \"{0}\"",intVar);
            Console.WriteLine("Double Variable = \"{0}\"", doubleVar);
            intVar = 1212938;
            doubleVar = 123212.234;
            Console.WriteLine("Integer Variable = \"{0}\"", intVar);
            Console.WriteLine("Double Variable = \"{0}\"", doubleVar);

        }
    }
