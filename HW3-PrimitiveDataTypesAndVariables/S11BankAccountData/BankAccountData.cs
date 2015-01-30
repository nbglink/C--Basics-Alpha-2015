using System;

namespace S11BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "John";
            string middleName = "Smith";
            string lastName = "Bond";
            string bankName = "Bilionare Bank";
            decimal balance = 25000000.5458999954821m;
            string IBAN = "GB29 NWBK 6016 1331 9268 19";
            long visa = 4532087913589293;
            long masterCard = 5389945573940984;
            long aExpress = 377667651704745;

            Console.WriteLine("A bank account has a holder name ({0} {1} {2}),\n\navailable amount of money ({3}),\n\nbank name: {4},\n\nIBAN: {5},\n\n\n3 credit card numbers associated with the account:",firstName,middleName,lastName,balance,bankName,IBAN);
            Console.WriteLine();
            Console.WriteLine("VISA {0}",visa);
            Console.WriteLine();
            Console.WriteLine("MasterCard {0}",masterCard);
            Console.WriteLine();
            Console.WriteLine("AmericanExpress {0}",aExpress);
            Console.WriteLine();
        }
    }
}
