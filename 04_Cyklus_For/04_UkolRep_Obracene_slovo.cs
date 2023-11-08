namespace obracene_slovo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string slovo = "kanárek";

            /*Na začátku i nabude hodnoty délky textového řetězce 'slovo'.
             *Délka řetězce se udává v počtu jeho znaků a jelikož indexování začíná od nuly. Tak slovo kanárek má sice 7 znaků ale má indexy 0–6, proto musíme na začátku délku o 1 snížit.
             *Následně se kontrolu zda i je větší než -1, protože nulu ještě musíme nechat projít.
             *Po každém průchodu cyklu se i o 1 snižuje.
             */
            for (int i = slovo.Length-1; i > -1; i--)
            {
                Console.WriteLine(slovo[i]);
            }
        }
    }
}