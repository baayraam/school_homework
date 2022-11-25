using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Netto_Brutto_Rechner
{
    class Program
    {
        static void Main(string[] args)
        {

            double xMwSt = 0.077;
            bool nochmalMachen = true;
            do
            {
                Console.WriteLine("Geben Sie den Preis Ihrer Ware ein:");
                string preisware;
                double Preisware;
                bool keineZahl = true;
                do
                {
                    preisware = Console.ReadLine();
                    if (!double.TryParse(preisware, out Preisware))
                    {
                        Console.WriteLine("{0} ist ein keine Zahl!", preisware);

                        Console.WriteLine("Bitte geben Sie eine Zahl ein: ");
                    }
                    else
                    {
                        keineZahl = false;
                    }
                } while (keineZahl);


                Console.WriteLine("Ihr Preis wird jetzt inklusive 7.7% Mehrwertsteuer ausgegeben:");
                double ergebnis = Preisware * xMwSt + Preisware;
                Console.WriteLine(ergebnis);


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
