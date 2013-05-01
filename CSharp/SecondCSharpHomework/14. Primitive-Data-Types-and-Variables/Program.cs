using System;

class Bank
{
    static void Main()
    {
        string firstName, middleName, lastName, bankName,BIC,IBAN;
        decimal balance;
        ulong firstNumber, secondNumber;
        Console.Write("Enter first name:");
        firstName = Console.ReadLine();
        Console.Write("Enter middle name:");
        middleName = Console.ReadLine();
        Console.Write("Enter last name:");
        lastName = Console.ReadLine();
        Console.Write("Enter bank name:");
        bankName = Console.ReadLine();
        Console.Write("Enter BIC:");
        BIC = Console.ReadLine();
        Console.Write("Enter IBAN:");
        IBAN = Console.ReadLine();
        Console.Write("Enter balance:");
        balance = Decimal.Parse(Console.ReadLine());
        Console.Write("Enter First Card Number:");
        firstNumber = ulong.Parse(Console.ReadLine());
        Console.Write("Enter Second Card Number:");
        secondNumber = ulong.Parse(Console.ReadLine());
    
        Console.WriteLine("Bank information: \n{0} {1} {2}\nbank name: {3}\nBIC:{4}\nIBAN: {5}\nbalance: {6}\nFirst Card Number: {7}\nSecond Card Number: {8}"
            , firstName, middleName, lastName, bankName, BIC, IBAN, balance,firstNumber,secondNumber);

    }
}