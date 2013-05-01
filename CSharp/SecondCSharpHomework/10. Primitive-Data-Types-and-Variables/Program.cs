using System;

class MarketingFirm
{
    static void Main()
    {
        string firstName, lastName;
        byte age;
        char gender;
        int IDNumber, employeeNumber;
        Console.Write("Enter first name:");
        firstName = Console.ReadLine();
        Console.Write("Enter last name:");
        lastName = Console.ReadLine();
        Console.Write("Enter age:");
        age = byte.Parse(Console.ReadLine());
        Console.Write("Enter gender(m or f):");
        gender = char.Parse(Console.ReadLine());
        Console.Write("Enter ID:");
        IDNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter employee number:");
        employeeNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Employee information: \n{0} {1}\nAge:{2}\nGender:{3}\nID:{4}\nEmployee Number:{5}", firstName, lastName, age, gender, IDNumber, employeeNumber);

    }
}