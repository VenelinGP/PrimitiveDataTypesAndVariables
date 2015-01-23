using System;

/*A bank account has a holder name (first name, middle name and last name), 
 * available amount of money (balance), bank name, IBAN,
 * 3 credit card numbers associated with the account.
 * Declare the variables needed to keep the information for a single bank 
 * account using the appropriate data types and descriptive names.
 */

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Georgiev";
        string lastName = "Ivanov";
        decimal balance = 10000.00m;
        string bankName = "First Investment Bank  AD";
        string iban = "BG04FINV81374567234561";
        long firstCard = 1234567890123456;
        long secondCard = 7890123456789012;
        long thirdCard = 3456789012345678;
        object fullName = firstName + " " + middleName + " " + lastName;
        Console.WriteLine("Name:  {0}\n" +
                           "Bank name:   {1}\n" +
                            "\n" +
                            "IBAN:        {2}         Balance:     {3} \n" +
                            "\n" +
                            "First card : {4}\n" +
                            "Second card: {5}\n" +
                            "Third card : {6}", (string)fullName, bankName, iban, balance, firstCard, secondCard, thirdCard);
    }
}
