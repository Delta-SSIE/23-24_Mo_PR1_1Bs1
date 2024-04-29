namespace slovnik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklarace slovníku s key string a value string
            Dictionary<string, string> zamAdresy = new Dictionary<string, string>();
            Dictionary<string, int> zamUcty = new Dictionary<string, int>();

            //Přidání prvku do slovníku
            zamAdresy.Add("Ruprecht", "Jablečná 123");
            zamAdresy.Add("Jirka", "Pražská 569");
            zamUcty.Add("Richard", 25);
            zamUcty.Add("Lumír", 450);

            //Výpis klíčů
            foreach (string key in zamAdresy.Keys)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine();

            //Výpis hodnot
            foreach (string value in zamAdresy.Values)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            //Výpis hodnot a klíčů v rámci jednoho foreach

            foreach (KeyValuePair<string, string> prvek in zamAdresy)
            {
                Console.Write($"Klíč: {prvek.Key} a jeho hodnota: {prvek.Value}");
                Console.WriteLine();
            }

            //Count

            Console.WriteLine(zamAdresy.Count());

            //Změna hodnoty v slovníku
            zamAdresy["Jirka"] = "Zatopená 753";
            Console.WriteLine(zamAdresy["Jirka"]);

            //Kolekce ze slovníku klíčů a hodnot

            Dictionary<string, string>.KeyCollection kolekceKlicu = zamAdresy.Keys;
            Dictionary<string, string>.ValueCollection kolekceHodnot = zamAdresy.Values;

            foreach (string klic in kolekceKlicu)
            {
                Console.Write(klic + " ");
            }
            Console.WriteLine();

            //Smazaní prvku ve slovníku
            zamAdresy.Remove("Ruprecht");

            foreach (KeyValuePair<string, string> prvek in zamAdresy)
            {
                Console.Write($"Klíč: {prvek.Key} a jeho hodnota: {prvek.Value}");
                Console.WriteLine();
            }

            //Pro vymazaní celého listu zamAdresy.Clear()

            //Hledání prvku ve slovníku, podle klíče a podle hodnoty

            Console.WriteLine(zamAdresy.ContainsKey("Jirka"));
            Console.WriteLine(zamAdresy.ContainsKey("Ulrich"));
            Console.WriteLine(zamUcty.ContainsKey("Lumír"));

            Console.WriteLine(zamAdresy.ContainsValue("Zatopená 753"));
            Console.WriteLine(zamAdresy.ContainsValue("Zatopená 1"));
            Console.WriteLine(zamUcty.ContainsValue(25));
        }
    }
}