using System;
using System.Text;

/*Write a program that prints an isosceles triangle of 9 copyright symbols  © , something like this:
 * 
 *    ©
 *   © ©
 *  ©   ©
 * © © © ©
 * 
 * Note: The  ©  symbol may be displayed incorrectly at the console so you may need to change 
 * the console character encoding to  UTF-8  and assign a Unicode-friendly font in the console.
 * Note: Under old versions of Windows the  ©  symbol may still be displayed incorrectly,
 * regardless of how much effort you put to fix it.
 */

class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            char myChar = '\u00A9';
            Console.WriteLine("    " + myChar);
            Console.WriteLine("   " + myChar + " "+myChar);
            Console.WriteLine("  " + myChar + "   "+myChar);
            Console.WriteLine(" " + myChar + " " + myChar + " " + myChar + " " + myChar);
            Console.WriteLine("");

            /* This code print Isosceles Triangle with different dimensions
             * You can channge the variable "dimension" to test.
             */

            int dimension = 4;
            for (int j = 0; j < dimension; j++){
                    Console.Write(" ");
                }
            Console.WriteLine(myChar);
            int difference = dimension - 1;
            for (int j = 0; j < dimension - 2; j++)
            {
                for (int i = 0; i < difference; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(myChar);
                for (int i = 0; i < (2*(dimension-difference)-1) ; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(myChar);
                difference--;
            }
            for (int j = 0; j < dimension; j++)
            {
                Console.Write (" "+myChar);
            }
            Console.WriteLine("");
        }
  
    }
