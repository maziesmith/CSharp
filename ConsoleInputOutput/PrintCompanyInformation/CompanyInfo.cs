//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.
//Company name:	Telerik Academy
//Company address:	31 Al. Malinov, Sofia
//Phone number:	+359 888 55 55 555
//Fax number:	2
//Web site:	http://telerikacademy.com/
//Manager first name:	Nikolay
//Manager last name:	Kostov
//Manager age:	25
//Manager phone:	+359 2 981 981
using System;

class CompanyInfo
{
    static void Main()
    {
        string compName = "Company name: ";
        string cAddress = "Company address:	";
        string phNum = "Phone number: ";
        string fNum = "Fax number: ";
        string web = "Web site: ";
        string mfname = "Manager first name: ";
        string mlname = "Manager last name: ";
        string mAge = "Manager age: ";
        string mPhone = "Manager phone:";

        Console.WriteLine(compName);
        string companyName = Console.ReadLine();
        Console.WriteLine(cAddress);
        string companyAddress = Console.ReadLine();
        Console.WriteLine(phNum);
        string phoneNUmber = Console.ReadLine();
        Console.WriteLine(fNum);
        string faxNumber = Console.ReadLine();
        Console.WriteLine(web);
        string webSite = Console.ReadLine();
        Console.WriteLine(mfname);
        string managerFirstName = Console.ReadLine();
        Console.WriteLine(mlname);
        string managerLastName = Console.ReadLine();
        Console.WriteLine(mAge);
        string managerAge = Console.ReadLine();
        Console.WriteLine(mPhone);
        string managerPhone = Console.ReadLine();
        
        string format = "{0,-20} {1,10}";

        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(format, compName, companyName);
        Console.WriteLine(format, cAddress, companyAddress);
        Console.WriteLine(format, phNum, phoneNUmber);
        Console.WriteLine(format, fNum, faxNumber);
        Console.WriteLine(format, web, webSite);
        Console.WriteLine(format, mfname, managerFirstName);
        Console.WriteLine(format, mlname, managerLastName);
        Console.WriteLine(format, mAge, managerAge);
        Console.WriteLine(format, mPhone, managerPhone);
        Console.WriteLine();
        
        
       
    }
}

