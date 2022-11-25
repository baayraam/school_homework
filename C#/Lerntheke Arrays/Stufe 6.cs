using System;

namespace Telefonbuch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viele Namen und Telefonnummern wollen sie eintragen?");
            int anzahl = Convert.ToInt32(Console.ReadLine());

            string[,] Telefonbuch = new string[anzahl, 2];

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine("Tragen sie ihren " + (i + 1) + ". Namen ein und danach die dazugehörige Telefonnummer:");
                Console.WriteLine((i + 1) + ". Name:");
                Telefonbuch[i, 0] = Console.ReadLine();
                Console.WriteLine((i + 1) + ". Telefonnummer:");
                Telefonbuch[i, 1] = Console.ReadLine();
            }
            Console.WriteLine("\n");

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine((i + 1) + ". Name: " + Telefonbuch[i, 0] + ", Telefonnumer: " + Telefonbuch[i, 1]);

            }

            Console.WriteLine("\n");
            Console.WriteLine("Wollen sie einen Kontakt austauschen?");

            string austauschen = Console.ReadLine();
            if (austauschen == "Ja" || austauschen == "ja")
            {
                Console.WriteLine("Welchen Kontakt möchten Sie austauschen?");
                Console.WriteLine("Geben Sie den Namen des Kontakts ein: \n");
                string welchenKontakt = Console.ReadLine();

                

            for (int i = 0; i < anzahl; i++)
            {
                if (welchenKontakt == Telefonbuch[i, 0])
                {
                        Console.WriteLine("Welchen Kontakt wollen sie Stattdessen speichern?");
                        Console.WriteLine("Geben sie den Namen ein:");
                        Telefonbuch[i, 0] = Console.ReadLine();
                        Console.WriteLine("Und nun die dazugehörige Nummer: ");
                        Telefonbuch[i, 1] = Console.ReadLine();
                }
            }
            }
            else
            {
                Console.WriteLine("Das Programm wird beendet!");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine((i + 1) + ". Name: " + Telefonbuch[i, 0] + ", Telefonnumer: " + Telefonbuch[i, 1]);

            }
            Console.WriteLine("\n");

            Console.ReadKey();
        }
    }
}