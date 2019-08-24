using System;

namespace DIce
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int terning;
            int en = 0;
            int to = 0;
            int tre = 0;
            int fire = 0;
            int fem = 0;
            int seks = 0;

            for (int i =1; i<1000; i++)
            {
                terning = random.Next(1, 7);
                Console.WriteLine(terning);
                if (terning == 1)
                {
                    en++;
                }
                if (terning == 2)
                {
                    to++;
                }
                if (terning == 3)
                {
                    tre++;
                }
                if (terning == 4)
                {
                    fire++;
                }
                if (terning == 5)
                {
                    fem++;
                }
                if (terning == 6)
                {
                    seks++;
                }



            }

            Console.WriteLine("Du har slået et {0} gange", en);
            Console.WriteLine("Du har slået to {0} gange", to);
            Console.WriteLine("Du har slået tre {0} gange", tre);
            Console.WriteLine("Du har slået fire {0} gange", fire);
            Console.WriteLine("Du har slået fem {0} gange", fem);
            Console.WriteLine("Du har slået seks {0} gange", seks);




        }
    }
}
