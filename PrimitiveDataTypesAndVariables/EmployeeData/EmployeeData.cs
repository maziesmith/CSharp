//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the information for a single employee 
//using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

    class Employee
    {
        static void Main()
        {
            string firstName = "Pesho";
            string lastName = "Peshev";
            byte age=21;
            char gender='m';
            long ID = 1234567890;
            int employeeNumber = 45678912;
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(ID);
            Console.WriteLine(employeeNumber);
        }
    }

