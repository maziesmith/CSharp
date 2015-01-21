//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Pesho";
            string middleName = "Peshev";
            string lastName = "Peshev";
            decimal balance = 1200350.4586954756321M;
            string bankName = "HypoVereinsBank";
            string IBAN = "DE40700202700012345678";
            long creditCard1 = 1234432156788765;
            long creditCard2 = 9876678943211234;
            long creditCard3 = 6541145623699632;
            Console.WriteLine("The bank account information: \n First Name: {0} \n Middle Name: {1} \n Last Name: {2} \n Balance: {3} \n Bank: {4} \n IBAN: {5} \n Credit Card1 Number: {6} \n Credit Card2 Number: {7} \n Credit Card3 Number: {8}", firstName, middleName, lastName, balance, bankName, IBAN, creditCard1,creditCard2,creditCard3);

        }
    }

