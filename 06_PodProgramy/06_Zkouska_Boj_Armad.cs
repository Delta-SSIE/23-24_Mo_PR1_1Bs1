namespace boj_armad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int[] nepritel = { gen.Next(5, 13), gen.Next(2, 7), gen.Next(2, 6) };
            int[] armada = { gen.Next(5, 13), gen.Next(2, 7), gen.Next(2, 6) };

            while (nepritel.Sum() > 0 && armada.Sum() > 0)
            {
                Console.WriteLine("Vaše armáda:");
                Vypis(armada);

                Console.WriteLine("Nepřátelská armáda:");
                Vypis(nepritel);

                Console.WriteLine("Pokud chceš zaútočit Pěchotou zadej 1, pokud střelci zadej 2, pokud jízdou zadej 3!");
                int roz = int.Parse(Console.ReadLine());
                switch (roz)
                {
                    case 1:
                        nepritel = Pechota(armada, nepritel);
                        break;
                    case 2:
                        nepritel = Strelba(armada, nepritel);
                        break;
                    case 3:
                        nepritel = Jizda(armada, nepritel);
                        break;
                }

                while (true)
                {
                    int utok = gen.Next(1, 4);
                    if (utok == 1 && nepritel[0] > 0)
                    {
                        armada = Pechota(nepritel, armada);
                        Console.WriteLine("Nepřítel útočí Pěchotou!");
                        break;
                    }
                    else if (utok == 2 && nepritel[1] > 0)
                    {
                        armada = Strelba(nepritel, armada);
                        Console.WriteLine("Nepřítel útočí Střelci!");
                        break;
                    }
                    else if (utok == 3 && nepritel[2] > 0)
                    {
                        armada = Jizda(nepritel, armada);
                        Console.WriteLine("Nepřítel útočí Jízdou!");
                        break;
                    }

                }

            }


        }
        public static void Vypis(int[] jednotky)
        {
                    Console.WriteLine("Pěchota: " + jednotky[0] + " Střelci: " + jednotky[1] + " Jízda: " + jednotky[2]);
        }

        public static int[] Pechota(int[] jednotky, int[] nepritel)
        {
            if (nepritel[0] > 0)
            {
                nepritel[0] =- Trefa(jednotky[0], 10);
            }
            else if (nepritel[2] > 0)
            {
                nepritel[2] =- Trefa(jednotky[0], 6);
            }
            else
            {
                nepritel[1] =- Trefa(jednotky[0], 3);
            }

            nepritel = Vynuluj(jednotky);

            return nepritel;
        }

        public static int[] Jizda(int[] jednotky, int[] nepritel)
        {
            if (nepritel[2] > 0)
            {
                nepritel[2] =- Trefa(jednotky[2], 8);
            }
            else if (nepritel[1] > 0)
            {
                nepritel[1] =- Trefa(jednotky[2], 2);
            }
            else
            {
                nepritel[0] =- Trefa(jednotky[2], 4);
            }

            nepritel = Vynuluj(jednotky);

            return nepritel;
        }

        public static int[] Strelba(int[] jednotky, int[] nepritel)
        {
            if (nepritel[0] > 0)
            {
                nepritel[0] =- Trefa(jednotky[1], 6);
            }
            else if (nepritel[1] > 0)
            {
                nepritel[1] =- Trefa(jednotky[1], 6);
            }
            else
            {
                nepritel[2] =- Trefa(jednotky[1], 6);
            }

            nepritel = Vynuluj(jednotky);

            return nepritel;
        }

        public static int[] Vynuluj(int[] jednotky)
        {
            for (int i = 0; i < jednotky.Length; i++)
            {
                if (jednotky[i] < 0)
                {
                    jednotky[i] = 0;
                }
            }

            return jednotky;
        }
        public static int Trefa(int pocet_jednotek, int pravdepodonost)
        {
            Random gen = new Random();
            int zabit = 0;

            for (int i = 0; i < pocet_jednotek; i++)
            {
                int trefa = gen.Next(1, pravdepodonost+1);
                if (trefa == 1)
                {
                    zabit++;
                }
            }

            Console.WriteLine($"Jednotka se trefila {zabit}");
            return zabit;
        }

    }
}