using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mittelwerte
{
    class Program
    {
        static void Main(string[] args)
        {

            bool nochmalMachen = true;

            Console.WriteLine("Guten Moin, willkommen zum Mittelwert Rechner!");
            do
            {
                Console.WriteLine("Wie viele Zahlen wollen sie eingeben?");

                string Zahlen;
                int anzahlZahlen;
                bool keineZahl = true;
                do
                {
                    Zahlen = Console.ReadLine();
                    if (!int.TryParse(Zahlen, out anzahlZahlen))
                    {
                        Console.WriteLine("{0} ist ein keine Zahl!", Zahlen);
                        Console.WriteLine("Geben Sie nun eine Zahl ein: ");
                    }
                    else
                    {
                        keineZahl = false;
                    }
                } while (keineZahl);




                Console.WriteLine("Alles klar, geben Sie nun " + anzahlZahlen + " Zahlen ein \n");

                double[] zahlen = new double[anzahlZahlen];

                for (int i = 0; i < zahlen.Length; i++)
                {
                    bool wiederKeineZahl = true;

                    do
                    {
                        Console.WriteLine("Geben Sie jetzt die " + (i + 1) + ". Zahl ein: ");
                        string zahl = Console.ReadLine();


                        if (!double.TryParse(zahl, out zahlen[i]))
                        {
                            Console.WriteLine("{0} ist ein keine Zahl!", zahl);
                        }
                        else
                        {
                            wiederKeineZahl = false;
                        }
                    } while (wiederKeineZahl);

                }

                Console.WriteLine("Der Mittelwert Ihrer Zahlen ist: " + zahlen.Average());


                Console.WriteLine("Wollen Sie nochmal den Mittelwert aus ihren Zahlen rechnen? (j/n)");
                string nochmal = Console.ReadLine();

                if (nochmal != "j")
                {
                    Console.WriteLine("Das Programm wird jetzt geschlossen!");
                    nochmalMachen = false;
                }
                else if (nochmal == "j")
                {

                }
                else
                {
                    Console.WriteLine("Sie haben den Falschen buchstaben eingegeben!! Das Programm wird jetzt geschlossen!");
                }

            } while (nochmalMachen);
            

            
        }
    }
}
