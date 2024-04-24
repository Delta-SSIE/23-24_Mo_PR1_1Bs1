namespace list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Založení nového listu stringů
            List<string> jmena = new List<string>();

            //Založení listu s nahraním dat z pole
            int[] cisla = { 15, 55, 10, 15 };
            List<Int32> listCisel = new List<Int32>(cisla);

            foreach (int a in listCisel)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Přidání prvku do listu Add
            jmena.Add("Honza");
            jmena.Add("Jirka");

            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Přidání rozsahu do listu (celého pole stringů)

            string[] jmena2 = { "Kuba", "Ruprecht", "Richard" };
            jmena.AddRange(jmena2);
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Výpis prvku z listu
            Console.WriteLine(jmena[0]);
            //Výpis properties
            Console.WriteLine(jmena.Capacity + " " + jmena.Count);


            //Vkládání nových prvků na konkrétní indexy (původní prvky se vymazuji)
            jmena.Insert(0, "Roman");
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
            jmena.InsertRange(0, jmena2);
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Smazaní prvků z listu
            jmena.Remove("Honza");
            //Vymazaní na konkrétním indexu
            jmena.RemoveAt(0);
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Vymazaní rozsahu
            jmena.RemoveRange(3, 2);
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();


            //Vymazaní celého pole
            // listCisel.Clear();

            //IndexOf a LastIndexOf
            Console.WriteLine(jmena.IndexOf("Ruprecht")); //0, protože to je první výskyt daného prvku v listu
            Console.WriteLine(jmena.IndexOf("Tomáš")); //-1 pokud není nalezen

            //Nalezení posledního výskytu daného prvku
            Console.WriteLine(jmena.LastIndexOf("Ruprecht")); //3 poslední výskyt odpovídajícího prvku v listu
            
            Console.WriteLine(jmena.IndexOf("Richard"));
            Console.WriteLine(jmena.LastIndexOf("Richard"));

            //Pro hledání prvku v poli hledám prvek a na konci řeším, jestli mám index kladný, či -1 (pokud to tak daný prvek v listu není)

            //Řazení listu
            jmena.Sort();
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            listCisel.Sort();
            foreach (int a in listCisel)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Obracené řazení
            jmena.Reverse();
            foreach (string a in jmena)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            listCisel.Reverse();
            foreach (int a in listCisel)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();

            //Konverze listu na pole
            string[] jmena3 = jmena.ToArray();

            foreach (string jmeno in jmena3)
            {
                Console.Write(jmeno + " ");
            }
            Console.WriteLine();

        }
    }
}