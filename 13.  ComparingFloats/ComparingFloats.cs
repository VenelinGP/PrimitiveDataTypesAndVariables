using System;

/* Write a program that safely compares floating-point numbers (double) with precision  eps = 0.000001 
 * Note: Two floating-point numbers  a  and  b  cannot be compared directly by  a == b  because of the nature
 * of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely 
 * to each other than a fixed constant  eps .
 */



class ComparingFloats
    {
        static void Main()
        {
            Console.Write("Please, type a real number a = ");
            string readFromKeyboard = Console.ReadLine();
            double a = Convert.ToDouble(readFromKeyboard);
            Console.Write("Please, type a real number b = ");
            readFromKeyboard = Console.ReadLine();
            double b = Convert.ToDouble(readFromKeyboard);
            double eps = 0.000001;
            double c = Math.Abs(a-b);
            if (c < eps)
            {
                //Console.WriteLine("c = {0}", c);
                Console.WriteLine("a and b are equal.");
            }
            else
            {
                //Console.WriteLine("c = {0}", c);
                Console.WriteLine("a and b are not equal.");
            }
        }
    }
