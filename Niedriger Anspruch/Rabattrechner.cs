using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabattrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nochmalMachen = true;

            do
            {
                Console.WriteLine("Geben sie den Normalpreis einer Ware ein:");
                string preisWare;
                double Preisware;
                bool keineZahl = true;


                do
                {
                    preisWare = Console.ReadLine();
                    if (!double.TryParse(preisWare, out Preisware))
                    {
                        Console.WriteLine("{0} ist ein keine Zahl!", preisWare);
                        Console.WriteLine("Geben Sie nun eine Zahl ein: ");
                    }
                    else
                    {
                        if (Preisware <= 0)
                        {
                            Console.WriteLine("Der Preis ihrer Ware kann nicht kleiner als null sein!");
                            Console.WriteLine("Versuchen sie es nochmal!");
                        }
                        else
                        {
                            keineZahl = false;
                        }
                    }


                } while (keineZahl);



                Console.WriteLine("Geben Sie jetzt den Rabatt in % ein:");
                string rabatt;
                double Rabatt;
                bool wiederKeineZahl = true;
                do
                {
                    rabatt = Console.ReadLine();
                    if (!double.TryParse(rabatt, out Rabatt))
                    {
                        Console.WriteLine("{0} ist ein keine Zahl!", rabatt);
                        Console.WriteLine("Geben Sie nun eine Zahl ein: ");
                    }
                    else
                    {
                        if (Rabatt <= 0)
                        {
                            Console.WriteLine("Der Rabatt kann nicht kleiner oder gleich null sein!");
                            Console.WriteLine("Versuchen sie es nochmal!");
                        }
                        else
                        {
                            wiederKeineZahl = false;
                        }

                    }
                } while (wiederKeineZahl);

                double ergebnis = Preisware / 100;
                ergebnis = ergebnis * Rabatt;
                ergebnis = Preisware - ergebnis;


                Console.WriteLine("Ihr Endpreis + den Rabatt ist:" + ergebnis);

                Console.WriteLine("Wollen Sie nochmal rechnen? (j/n)");
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
