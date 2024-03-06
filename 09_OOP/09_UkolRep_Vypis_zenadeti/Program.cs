namespace Vypis_zen_a_deti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //vytvoříme jeden zkušební objekt
            Person tom = new Person
            {
                Name = "Tom",
                Surname = "Riddle",
                Age = 9,
                Sex = SexType.Male
            };

            //ověříme, že jsme správně zapsali jeho představení
            Console.WriteLine(tom.IntroduceSelf());

            // nyní připravíme pole osob
            Person[] friends = new Person[]
            {
                new Person {
                    Name = "Thomas",
                    Surname = "Carter",
                    Age = 17,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lillian",
                    Surname = "Carter",
                    Age = 19,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Jim",
                    Surname = "Pearson",
                    Age = 54,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Lou",
                    Surname = "Lacey",
                    Age = 36,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Minnie",
                    Surname = "Stanfords",
                    Age = 84,
                    Sex = SexType.Female
                },
                new Person {
                    Name = "Quincy",
                    Surname = "Dean",
                    Age = 12,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Steve",
                    Surname = "Blake",
                    Age = 61,
                    Sex = SexType.Male
                },
                new Person {
                    Name = "Andrew",
                    Surname = "Holmes",
                    Age = 33,
                    Sex = SexType.Male
                }
            };

            Console.WriteLine();
            FindKids(friends);
            Console.WriteLine();
            FindWomen(friends);

        }
        public static void FindKids(Person[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (list[i].Age < 18)
                {
                    Console.WriteLine(list[i].IntroduceSelf());
                }
            }
        }

        public static void FindWomen(Person[] list)
        {
            foreach (Person osoba in list)
            {
                if (osoba.Sex == SexType.Female)
                {
                    Console.WriteLine(osoba.IntroduceSelf());
                }
            }
        }
    }
}