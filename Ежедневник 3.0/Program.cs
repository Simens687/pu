namespace Ежедневник_3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateOnly date = new DateOnly(2022, 10, 13);
            /*DateOnly date10 = new DateOnly(2022, 10, 10);
            DateOnly date15 = new DateOnly(2022, 10, 15);
            DateOnly date18 = new DateOnly(2022, 10, 18);
            DateOnly date31 = new DateOnly(2022, 10, 31);*/

            ConsoleKeyInfo key = Console.ReadKey();

            do
            {
                Pdate(date, key);
            }
            while (key.Key == ConsoleKey.Escape);
        }

        static List<Zametka> Z()
        {
            Zametka zam1 = new Zametka();
            zam1.Name = "Потерять наушники";

            Zametka zam2 = new Zametka();
            zam2.Name = "Посидеть в ментовке метро";

            Zametka zam3 = new Zametka();
            zam3.Name = "Застрять в туалете";

            Zametka zam4 = new Zametka();
            zam4.Name = "Купить оч дорогоe мороженое";

            Zametka zam5 = new Zametka();
            zam5.Name = "День рождения мамочки";

            Zametka zam6 = new Zametka();
            zam6.Name = "Годовщина";

            List<Zametka> zametki = new List<Zametka>();
            zametki.Add(zam1);
            zametki.Add(zam2);
            zametki.Add(zam3);
            zametki.Add(zam4);
            zametki.Add(zam5);
            zametki.Add(zam6);

            return zametki;
        }

        static void Pdate(DateOnly date, ConsoleKeyInfo key)
        {
            DateOnly date10 = new DateOnly(2022, 10, 10);
            DateOnly date15 = new DateOnly(2022, 10, 15);
            DateOnly date18 = new DateOnly(2022, 10, 18);
            DateOnly date31 = new DateOnly(2022, 10, 31);

            while (key.Key == ConsoleKey.RightArrow || key.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();

                if (key.Key == ConsoleKey.RightArrow)
                {
                    date = date.AddDays(1);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    date = date.AddDays(-1);
                }

                Chislo(date);

                if (date == date15 || date == date31)
                {
                    Menu2(date, date15, date31);
                }
                else if (date == date10 || date == date18)
                {
                    Menu1(date, date10, date18);
                }

                key = Console.ReadKey();

            }
        }

        static void Chislo(DateOnly date)
        {
            Console.WriteLine(date);
        }

        static void Menu2(DateOnly date, DateOnly date15, DateOnly date31)
        {
            VMenu2(date, date15, date31);


            ConsoleKeyInfo key = Console.ReadKey();

            int posa = 1;

            Console.Clear();

            while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(date);

                VMenu2(date, date15, date31);

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    posa--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    posa++;
                }

                if (posa == 3)
                {
                    posa = 1;
                }

                if (posa == 0)
                {
                    posa = 2;
                }

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                Console.Clear();
            }
            while (key.Key == ConsoleKey.Enter)
            {
                if (date == date15)
                {
                    Opis2(date, date15, date31, posa);
                    ConsoleKeyInfo key1 = Console.ReadKey();
                    if (key1.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }

                else if (date == date31)
                {
                    Opis2(date, date15, date31, posa);
                    ConsoleKeyInfo key1 = Console.ReadKey();
                    if (key1.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                }

            }
        }

        static void VMenu2(DateOnly date, DateOnly date15, DateOnly date31)
        {
            List<Zametka> zametki = Z();

            if (date == date15)
            {
                Console.Write("   1. "); Console.WriteLine(zametki[0].Name);
                Console.Write("   2. "); Console.WriteLine(zametki[1].Name);
            }

            if (date == date31)
            {
                Console.Write("   1. "); Console.WriteLine(zametki[4].Name);
                Console.Write("   2. "); Console.WriteLine(zametki[5].Name);
            }
        }

        static void Menu1(DateOnly date, DateOnly date10, DateOnly date18)
        {
            VMenu1(date, date10, date18);
            Console.SetCursorPosition(0, 1);
            Console.Write("->");

            ConsoleKeyInfo key = Console.ReadKey();

            int posa = 1;

            Console.Clear();

            while (key.Key == ConsoleKey.UpArrow || key.Key == ConsoleKey.DownArrow)
            {

                Console.WriteLine(date);

                VMenu1(date, date10, date18);

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    posa--;
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    posa++;
                }

                if (posa != 1)
                {
                    posa = 1;
                }

                Console.SetCursorPosition(0, posa);
                Console.WriteLine("->");

                Console.Clear();
            }
            while (key.Key == ConsoleKey.Enter)
            {

                Opis1(date, date10, date18);
                ConsoleKeyInfo key1 = Console.ReadKey();
                if (key1.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    break;
                }

            }
        }

        static void VMenu1(DateOnly date, DateOnly date10, DateOnly date18)
        {
            List<Zametka> zametki = Z();

            if (date == date10)
            {
                Console.Write("   1. "); Console.WriteLine(zametki[3].Name);
            }

            if (date == date18)
            {
                Console.Write("   1. "); Console.WriteLine(zametki[2].Name);
            }
        }

        static List<Zametka> OZ()
        {
            Zametka Ozam1 = new Zametka();
            Ozam1.Opisanie = "Расстроиться";

            Zametka Ozam2 = new Zametka();
            Ozam2.Opisanie = "Обосраться";

            Zametka Ozam3 = new Zametka();
            Ozam3.Opisanie = "Сходить в душ";

            Zametka Ozam4 = new Zametka();
            Ozam4.Opisanie = "Милку или сникерс";

            Zametka Ozam5 = new Zametka();
            Ozam5.Opisanie = "Подарок";

            Zametka Ozam6 = new Zametka();
            Ozam6.Opisanie = "Второй подарок";

            List<Zametka> Ozametki = new List<Zametka>();
            Ozametki.Add(Ozam1);
            Ozametki.Add(Ozam2);
            Ozametki.Add(Ozam3);
            Ozametki.Add(Ozam4);
            Ozametki.Add(Ozam5);
            Ozametki.Add(Ozam6);

            return Ozametki;
        }

        static void Opis1(DateOnly date, DateOnly date10, DateOnly date18)
        {
            List<Zametka> Ozametki = OZ();
            List<Zametka> zametki = Z();

            if (date == date10)
            {
                Console.WriteLine(zametki[3].Name);
                Console.WriteLine("--------------------------");
                Console.WriteLine(Ozametki[3].Opisanie);
                Console.WriteLine("Сделать " + date);
            }
            else if (date == date18)
            {
                Console.WriteLine(zametki[2].Name);
                Console.WriteLine("--------------------------");
                Console.WriteLine(Ozametki[2].Opisanie);
                Console.WriteLine("Сделать " + date);
            }
        }

        static void Opis2(DateOnly date, DateOnly date15, DateOnly date31,int posa)
        {
            List<Zametka> Ozametki = OZ();
            List<Zametka> zametki = Z();

            if (date == date15)
            {
                if (posa == 1)
                {
                    Console.WriteLine(zametki[0].Name);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(Ozametki[0].Opisanie);
                    Console.WriteLine("Сделать " + date);
                }

                if (posa == 2)
                {
                    Console.WriteLine(zametki[1].Name);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(Ozametki[1].Opisanie);
                    Console.WriteLine("Сделать " + date);
                }
            }
            else if (date == date31)
            {
                if (posa == 1)
                {
                    Console.WriteLine(zametki[4].Name);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(Ozametki[4].Opisanie);
                    Console.WriteLine("Сделать " + date);
                }

                if (posa == 2)
                {
                    Console.WriteLine(zametki[5].Name);
                    Console.WriteLine("--------------------------");
                    Console.WriteLine(Ozametki[5].Opisanie);
                    Console.WriteLine("Сделать " + date);
                }
            }
        }
    }
}