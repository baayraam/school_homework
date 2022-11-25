using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zahlenfolge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool durchlauf = true;

            do
            {
                Console.WriteLine("Gib eine Zahl ein:");
                string Z;
                int z;
                bool keineZahl = true;

                do
                {

                    Z = Console.ReadLine();

                    if (!int.TryParse(Z, out z))
                    {
                        Console.WriteLine("{0} ist keine Zahl!\n Versuchen Sie es erneut:", Z);
                    }
                    else if (z <= 0)
                    {
                        Console.WriteLine("{0} darf nicht kleiner oder gleich 0 sein!!", z);
                    }
                    else
                    {
                        keineZahl = false;
                    }

                } while (keineZahl);



                if (z % 3 == 0)
                {
                    Console.WriteLine("Deine Zahl wird um 4 erhöht, da sie durch 3 teilbar ist!");
                    z += 4;
                    Console.WriteLine("Deine Zahl ist jetzt: " + z);
                }
                else if (z % 4 == 0)
                {
                    z = z / 4;
                    Console.WriteLine("Dein Wert wird abgerundet, da sie nicht durch 3, aber durch 4 teilbar ist!");
                    Console.WriteLine("Deine Zahl ist jetzt: " + z);
                }
                else
                {
                    Console.WriteLine("Deine Zahl wird um 1 verringert, da sie weder durch 3 noch durch 4 teilbar ist!");
                    z -= 1;
                    Console.WriteLine("Deine Zahl ist jetzt: " + z);
                }

                Console.WriteLine("Wollen Sie das Programm neustarten?(J/N)");
                string nochmal = Console.ReadLine();

                if (nochmal == "J" || nochmal == "j")
                {

                }
                else
                {
                    durchlauf = false;
                }

            } while (durchlauf);




        }
    }
}
