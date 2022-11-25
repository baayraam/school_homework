namespace Lerntheke_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Dreieck

            //bool nochmal = true;

            //do
            //{
            //    Console.WriteLine("Dreieck \n");

            //    Console.WriteLine("Geben sie nun 3 Zahlen, für die Länge dreier Seiten eines Dreiecks ein: ");

            //    double[] seitenLänge = new double[3];

            //    for (int i = 0; i < seitenLänge.Length; i++)
            //    {
            //        bool keineZahl = true;

            //        do
            //        {
            //            Console.WriteLine((i + 1) + ". Seite");
            //            string seite = Console.ReadLine();

            //            if (!double.TryParse(seite, out seitenLänge[i]))
            //            {
            //                Console.WriteLine("{0} ist keine Zahl!", seite);
            //            }
            //            else
            //            {
            //                keineZahl = false;
            //            }
            //        } while (keineZahl);
            //    }

            //    for (int i = 0; i < seitenLänge.Length; i++)
            //    {
            //        Console.WriteLine("Das ist ihre " + (i + 1) + ".  Seite: ");
            //        Console.WriteLine(seitenLänge[i]);
            //    }

            //    Console.WriteLine("\n");

            //    if (seitenLänge[0] == seitenLänge[1] && seitenLänge[1] == seitenLänge[2] && seitenLänge[2] == seitenLänge[0])
            //    {
            //        Console.WriteLine("Ihr Dreieck ist ein gleichseitiges Dreieck");
            //        Console.WriteLine("Das bedeutet alle Seiten ihres Dreiecks sind gleich lang");
            //    }
            //    else if (seitenLänge[0] == seitenLänge[1] || seitenLänge[1] == seitenLänge[2] || seitenLänge[2] == seitenLänge[0])
            //    {
            //        Console.WriteLine("Ihr Dreieck ist ein gleichschenkliges Dreieck");
            //        Console.WriteLine("Das bedeutet 2 Seiten ihres Dreiecks sind gleich lang");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ihr Dreieck ist ein allgemeines Dreieck");
            //        Console.WriteLine("Das bedeutet keine Seiten ihres Dreiecks sind gleich lang");
            //    }

            //    bool erneut = true;
            //    do
            //    {
            //        Console.WriteLine("Wollen sie das Programm nochmal ausführen? (j/n)");

            //        string nochmalAbfrage = Console.ReadLine();

            //        if (nochmalAbfrage == "n")
            //        {
            //            Console.WriteLine("Das Programm wird beendet!");
            //            nochmal = false;
            //            erneut = false;
            //        }
            //        else if (nochmalAbfrage == "j")
            //        {
            //            erneut = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sie haben ein falsches zeichen eingegeben \n versuchen Sie es erneut");
            //            erneut = true;
            //        }
            //    } while (erneut);

            //} while (nochmal);

            #endregion

            #region Primzahl

            //Console.WriteLine("Primzahlen finder \n");
            //bool nochmal = true;


            //do
            //{
            //    Console.WriteLine("Geben sie eine Zahl ein die Größer als 2 ist!");
            //    string primzahl;
            //    int Primzahl;

            //    bool keineZahl = true;
            //    bool istPrimzahl = true;

            //    do
            //    {
            //        primzahl = Console.ReadLine();

            //        if (!int.TryParse(primzahl, out Primzahl))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", primzahl);
            //            Console.WriteLine("Geben sie bitte eine Zahl über 2 ein");
            //        }
            //        else
            //        {
            //            if (Primzahl < 2)
            //            {
            //                Console.WriteLine("Ihre Zahl darf nicht kleiner als 2 sein!");
            //                Console.WriteLine("Versuchen sie es nochmal: ");
            //            }
            //            else
            //            {
            //                keineZahl = false;
            //            }
            //        }

            //    } while (keineZahl);


            //    for (int i = 2; i <= Primzahl; i++)
            //    {
            //        for (int j = 2; j <= Primzahl; j++)
            //        {
            //            if (i != j && i % j == 0)
            //            {
            //                istPrimzahl = false;
            //                break;
            //            }
            //        }

            //        if (istPrimzahl)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        istPrimzahl = true;
            //    }

            //    bool erneut = true;
            //    do
            //    {
            //        Console.WriteLine("Wollen sie das Programm nochmal ausführen? (j/n)");

            //        string nochmalAbfrage = Console.ReadLine();

            //        if (nochmalAbfrage == "n")
            //        {
            //            Console.WriteLine("Das Programm wird beendet!");
            //            nochmal = false;
            //            erneut = false;
            //        }
            //        else if (nochmalAbfrage == "j")
            //        {
            //            erneut = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sie haben ein falsches zeichen eingegeben \n versuchen Sie es erneut");
            //            erneut = true;
            //        }
            //    } while (erneut);
            //} while (nochmal);

            #endregion

            #region Rechteck zeichnen

            //bool nochmal = true;
            //do
            //{
            //    bool keineZahl = true;
            //    Console.WriteLine("Wie hoch soll ihr Rechteck sein? Geben sie eine Zahl über 1 ein:");
            //    string Höhe;

            //    int höhe;
            //    do
            //    {
            //        Höhe = Console.ReadLine();

            //        if (!int.TryParse(Höhe, out höhe))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", Höhe);
            //            Console.WriteLine("Geben sie bitte eine Zahl über 1 ein");
            //        }
            //        else
            //        {
            //            if (höhe <= 1)
            //            {
            //                Console.WriteLine("Ihre Zahl muss größer als ein 1 sein!");
            //                Console.WriteLine("Versuchen sie es nochmal: ");
            //            }
            //            else
            //            {
            //                keineZahl = false;
            //            }
            //        }

            //    } while (keineZahl);




            //    keineZahl = true;
            //    Console.WriteLine("Wie hoch soll ihr Rechteck sein? Geben sie eine Zahl über 1 ein:");
            //    string Breite;

            //    int breite;
            //    do
            //    {
            //        Breite = Console.ReadLine();

            //        if (!int.TryParse(Breite, out breite))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", Breite);
            //            Console.WriteLine("Geben Sie bitte eine Zahl ein:");
            //        }
            //        else
            //        {
            //            if (breite <= 1 || breite >= 10)
            //            {
            //                Console.WriteLine("Ihre Zahl darf nicht kleiner als 1 oder größer als 10 sein!");
            //                Console.WriteLine("Versuchen sie es nochmal: ");
            //            }
            //            else
            //            {
            //                keineZahl = false;
            //            }
            //        }

            //    } while (keineZahl);

            //    double[,] rechteck = new double[höhe, breite];

            //    for (int i = 0; i < rechteck.GetLength(0); i++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.Write("+");
            //            for (int j = 0; j < rechteck.GetLength(1); j++)
            //            {
            //                Console.Write("-");
            //            }
            //            Console.WriteLine("+");
            //        }

            //        Console.Write("|");
            //        for (int m = 0; m < rechteck.GetLength(1); m++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.WriteLine("|");

            //        if (i == höhe -1)
            //        {
            //            Console.Write("+");
            //            for (int k = 0; k < rechteck.GetLength(1); k++)
            //            {
            //                Console.Write("-");
            //            }
            //            Console.Write("+");
            //        }

                    
            //    }

            //    Console.WriteLine(" ");
            //    bool erneut = true;
            //    do
            //    {
            //        Console.WriteLine("Wollen sie das Programm nochmal ausführen? (j/n)");

            //        string nochmalAbfrage = Console.ReadLine();

            //        if (nochmalAbfrage == "n")
            //        {
            //            Console.WriteLine("Das Programm wird beendet!");
            //            nochmal = false;
            //            erneut = false;
            //        }
            //        else if (nochmalAbfrage == "j")
            //        {
            //            erneut = false;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Sie haben ein falsches zeichen eingegeben \n versuchen Sie es erneut");
            //            erneut = true;
            //        }
            //    } while (erneut);

            //} while (nochmal);

            #endregion
        }
    }
}