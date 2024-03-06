using System;

public class BankAccount
{
    public int AccountNumber;
    public string AccountHolderName;
    public double AccountBalance;
    public string AccountType;
  
    public BankAccount(int cislo, string jmeno, double castka, string typ)
    {
        this.AccountNumber = cislo;
        AccountHolderName = jmeno;
        AccountBalance = castka;
        AccountType = typ;
    }

    public void Deposit(double castka)
    {
        AccountBalance += castka;
        Console.WriteLine($"Na účtu je nyní {AccountBalance} zůstatek!");
    }

    public void Withdrawal(double castka)
    {
        if(AccountBalance < castka)
        {
            Console.WriteLine("Nemáš dostatek peněz na účtu!");
        } else
        {
            AccountBalance -= castka;
            Console.WriteLine($"Na účtu je nyní {AccountBalance} zůstatek!");
        }
    }
}
