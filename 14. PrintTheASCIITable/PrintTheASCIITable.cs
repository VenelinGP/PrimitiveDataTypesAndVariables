using System;

/* Find online more information about ASCII (American Standard Code for Information Interchange) and write
 * a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 * Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently
 * Note: You may need to use for-loops (learn in Internet how).
 */

class PrintTheASCIITable
    {
        static void Main()
        {
            Console.WriteLine("ASCII 0 = Null");
            Console.WriteLine("ASCII 1 = Start of heading");
            Console.WriteLine("ASCII 2 = Start of text");
            Console.WriteLine("ASCII 3 = Start of text");
            Console.WriteLine("ASCII 4 = End of trnasmit");
            Console.WriteLine("ASCII 5 = Enquiry");
            Console.WriteLine("ASCII 6 = Acknowledge");
            Console.WriteLine("ASCII 7 = Audible bell");
            Console.WriteLine("ASCII 8 = Backspace");
            Console.WriteLine("ASCII 9 = Horizontal tab");
            Console.WriteLine("ASCII 10 = Line feed");
            Console.WriteLine("ASCII 11 = Vertical tab");
            Console.WriteLine("ASCII 12 = Form feed");
            Console.WriteLine("ASCII 13 = Carriage return");
            Console.WriteLine("ASCII 14 = Shift out");
            Console.WriteLine("ASCII 15 = Shift in");
            Console.WriteLine("ASCII 16 = Data link escape");
            Console.WriteLine("ASCII 17 = Device control 1");
            Console.WriteLine("ASCII 18 = Device control 2");
            Console.WriteLine("ASCII 19 = Device control 3");
            Console.WriteLine("ASCII 20 = Device control 4");
            Console.WriteLine("ASCII 21 = Neg. acknowledge");
            Console.WriteLine("ASCII 22 = Synchronous idle");
            Console.WriteLine("ASCII 23 = End trans. block");
            Console.WriteLine("ASCII 24 = Cancel");
            Console.WriteLine("ASCII 25 = End of medium");
            Console.WriteLine("ASCII 26 = Substitution");
            Console.WriteLine("ASCII 27 = Escape");
            Console.WriteLine("ASCII 28 = File separator");
            Console.WriteLine("ASCII 29 = Group separator");
            Console.WriteLine("ASCII 30 = Record separator");
            Console.WriteLine("ASCII 31 = Unit separator");
            Console.WriteLine("ASCII 32 = Space");
            for (int counter = 33; counter < 255; counter++)
            {
                Console.WriteLine("ASCII {0} = {1}", counter, (char)counter);
            }

        }
    }
