// A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
// bank name, IBAN, 3 credit card numbers associated with the account.
// Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Mihaijlov";
        string lastName = "Ognqnov";
        decimal accountBalance = 2234.54m;
        string bankName = "Unicredit Bulbank";
        string iban = "BG80UNCR96611020345678";
        long firstCreditCardNumber = 4470547948501234L;
        long secondCreditCardNumber = 5423795015723547L;
        long thirdCreditCardNumber = 5400235712543780L;

        Console.WriteLine("Account holder: {0} {1} {2}", firstName, middleName, lastName);
        Console.WriteLine("Account balance: {0} BGN", accountBalance);
        Console.WriteLine("Bank: {0}", bankName); ;
        Console.WriteLine("IBAN: {0}", iban);
        Console.WriteLine("Credit cards numbers: 1. {0}; 2. {1}; 3. {2}.", firstCreditCardNumber, secondCreditCardNumber, thirdCreditCardNumber);
    }
}