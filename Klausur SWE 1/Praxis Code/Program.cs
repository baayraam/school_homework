namespace Klausur_1_Praxis_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int gewürzTausch;


                Console.WriteLine("Sie müssen nun einen Gewürzschrank mit Gewürzen füllen die nach der Reihe durchnummeriert sind: \n");


                Console.WriteLine("Wie Groß ist Ihr Gewürzschrank, geben Sie eine Zahl ein:");
                int arrayLänge = zahleneingabe();


                int[] Gewürzregal = new int[arrayLänge];


                for (int i = 0; i < Gewürzregal.Length; i++)
                {
                    Console.WriteLine("Geben Sie das {0}. Gewürz ein: ", (i + 1));
                    Gewürzregal[i] = zahleneingabe();
                }



                ArrayAusgabe(Gewürzregal);


                Console.WriteLine("Möchten sie ein Gewürz tauschen? (J/N)");
                do
                {
                    string abfrage = Console.ReadLine();


                    if (abfrage == "J" || abfrage == "j")
                    {
                        Console.WriteLine("Welches Gewürz wollen Sie ändern?");
                        gewürzTausch = zahleneingabe();


                        Console.WriteLine("Welche Zahl wollen Sie stattdessen tauschen");


                        for (int i = 0; i < Gewürzregal.Length; i++)
                        {
                            if (gewürzTausch == (i + 1))
                            {
                                int neuesGewürz = zahleneingabe();
                                if (neuesGewürz == Gewürzregal[i])
                                {
                                    Console.WriteLine("Die eingegebene Zahl ist die selbe wie davor! Der Tausch wird bestätigt ohne etwas getauscht zu haben!");
                                }
                                else
                                {
                                    Gewürzregal[i] = neuesGewürz;
                                }
                            }
                        }
                        break;
                    }
                    else if (abfrage == "N" || abfrage == "n")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sie haben etwas falsches eingegeben: {0}. Bitte geben Sie (J/N) ein:", abfrage);
                    }
                } while (true);


                Console.Clear();


                Console.WriteLine("Das sind Ihre Gewürze \n ");
                ArrayAusgabe(Gewürzregal);


                Console.WriteLine("Wollen Sie das Programm neu starten? (J/N)");
                string Programmneustarten = Console.ReadLine();


                if (Programmneustarten == "J" || Programmneustarten == "j")
                {


                }
                else
                {
                    Console.WriteLine("Programm wird beendet!");
                    break;
                }
            } while (true);
        }
        public static void ArrayAusgabe(int[] Gewürzregal)
        {
            for (int i = 0; i < Gewürzregal.Length; i++)
            {
                Console.WriteLine("Dein {0}. Gewürz hat die Zahl: {1}", (i + 1), Gewürzregal[i]);
            }
        }
        public static int zahleneingabe()
        {
            int zahl;
            do
            {
                if (int.TryParse(Console.ReadLine(), out zahl))
                {
                    return zahl;
                }
            } while (true);
        }
    }
}