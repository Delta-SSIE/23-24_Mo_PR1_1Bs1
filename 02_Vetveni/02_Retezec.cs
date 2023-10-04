namespace retezec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Hello World";
            string b = "Ahoj Světě";
            
            //Délka řetězce
            Console.WriteLine(a.Length);

            //Capslock
            Console.WriteLine(a.ToUpper());
            Console.WriteLine(a.ToLower());

            //Spojení řetězců
            Console.WriteLine(string.Concat(a," ",b));

            //Placeholder
            Console.WriteLine($"Text jedna je {a} a text dva je {b}");

            //Rozbití řetězce na jeho kusy
            Console.WriteLine(a[6]);

            //Hledání indexu znaku
            Console.WriteLine(a.IndexOf("W"));

            //Speciální znaky
            Console.WriteLine("Ahoj teď chci napsat uvozvoku jednoduchou \' a dvojitou \"  a další text bude na \nNovém řádku!");
        }
    }
}