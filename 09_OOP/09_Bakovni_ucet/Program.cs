namespace banka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount muj_ucet = new BankAccount(10, "Jan", 200, "gold");
            int volba = 0;
            double suma = 0;

            while (true)
            {
                Console.WriteLine("Vítej ve správě svého účtu \nPro výběr dej 1 Pro vklad dej 2");
                try
                {
                    volba = int.Parse(Console.ReadLine());
                } catch
                {
                    Console.WriteLine("Zadal jsi nesmysl");
                }
                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadej sumu, co chceš vybrat");
                        try
                        {
                            suma = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Zadal jsi nesmysl");
                        }
                        muj_ucet.Withdrawal(suma);
                        break;
                    case 2:
                        Console.WriteLine("Zadej sumu, co chceš vložit");
                        try
                        {
                            suma = double.Parse(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Zadal jsi nesmysl");
                        }
                        muj_ucet.Deposit(suma);
                        break;

                }
            }
        }
    }
}