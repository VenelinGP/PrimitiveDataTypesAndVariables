using System;

/* Declare five variables choosing for each of them the most appropriate of the types
 * byte, sbyte, short, ushort, int, uint, long, ulong  to represent 
 * the following values:  52130, -115, 4825932, 97, -10000. 
 * Choose a large enough type for each number to ensure it will fit in it.
 * Try to compile the code.
 * Submit the source code of your Visual Studio project as part of your homework submission.
*/

class DeclareVariables
{
    static void Main()
    {
        ushort firstVariable = 52130;
        sbyte secondVariable = -115;
        int thirdVariable = 4825932;
        byte fourthVariable = 97;
        short fifthVariable = -10000;
        Console.WriteLine("The variable {0} is \"ushort\" type!", firstVariable);
        Console.WriteLine("The variable {0} is \"sbyte\" type!", secondVariable);
        Console.WriteLine("The variable {0} is \"int\" type!", thirdVariable);
        Console.WriteLine("The variable {0} is \"byte\" type!", fourthVariable);
        Console.WriteLine("The variable {0} is \"short\" type!", fifthVariable);
    }
}