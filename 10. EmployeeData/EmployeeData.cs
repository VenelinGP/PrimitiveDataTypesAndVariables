using System;

/* A marketing company wants to keep record of its employees. Each record would have the following characteristics:
 * First name
 * Last name
 * Age (0...100)
 * Gender (m or f)
 * Personal ID number (e.g. 8306112507)
 * Unique employee number (27560000…27569999)
 * Declare the variables needed to keep the information for a single employee using appropriate primitive data types.
 * Use descriptive names. Print the data at the console.
 */

class EmployeeData
    {
        static void Main()
        {
            string firstName = "Ivan";
            string lastName = "Ivanov";
            byte Age = 45;
            char gender = 'm';
            long personalID = 6902255806;
            int employeeNumber = 27560095;
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            Console.WriteLine(" Age: {0} Gender: {1} \n", Age, gender);
            Console.WriteLine(" Personal ID: {0}", personalID);
            Console.WriteLine(" Employee Number: {0} \n", employeeNumber);
        }
    }
