namespace Mittlerer_Anspruch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sterne

            //bool durchlaufen = true;
            //bool programmstart = true;

            // do
            //    {
            //        Console.WriteLine("Wollen Sie das Programm starten?(J/N)");
            //        string programmstarten = Console.ReadLine();

            //        if (programmstarten == "j" || programmstarten == "J")
            //        {
            //            programmstart = false;
            //        }
            //        else if (programmstarten == "n" || programmstarten == "N")
            //        {
            //            durchlaufen = false;
            //            programmstart = false;

            //        }
            //        else
            //        {
            //            Console.WriteLine("Sie haben ein falsches Zeichen eingegeben! \n versuchen Sie es nochmal!");
            //        }
            //    } while (programmstart);

            //while (durchlaufen)
            //{
            //    bool keineZahl = true;
            //    Console.WriteLine("Hallo, Gib ein wie viele Reihen an Sternen du haben willst:");
            //    string sternreihen;
            //    double SternReihen;


            //    do
            //    {
            //        sternreihen = Console.ReadLine();

            //        if (!double.TryParse(sternreihen, out SternReihen))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl versuchen sie es erneut!", sternreihen);
            //        }
            //        else
            //        {
            //            keineZahl=false;
            //        }
            //    } while (keineZahl);

            //    for (int i = 1; i <= SternReihen; i++)
            //    {
            //        Console.WriteLine("**********");
            //    }

            //    Console.WriteLine("Wollen Sie das Programm neustarten?(J/N)");
            //    string nochmal = Console.ReadLine();
            //    if (nochmal == "N" || nochmal == "n")
            //    {
            //        durchlaufen = false;
            //    }
            //    else if (nochmal == "j" || nochmal == "J")
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Sie haben ein falsches Zeichen eingegeben, das Programm wird jetzt beendet!");
            //        durchlaufen = false;
            //    }
            //}
            #endregion

            #region  Fakultät
            //bool durchlauf = true;
            //bool keineZahl = true;
            //do
            //{
            //    Console.WriteLine("Geben Sie die erste Zahl ein mit der Sie die Fakultät berechnen wollen:");
            //    string Zahl;
            //    double zahl;

            //    do
            //    {
            //        Zahl = Console.ReadLine();

            //        if (!double.TryParse(Zahl, out zahl))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", Zahl);
            //            Console.WriteLine("Versuchen Sie es erneut: ");
            //        }
            //        else
            //        {
            //            keineZahl = false;
            //        }
            //    } while (keineZahl);

            //    double Fakultät = 1;
            //    for (int i = 1; i <= zahl; i++)
            //    {
            //        Fakultät *= i;
            //    }

            //    Console.WriteLine("\n" + zahl + "!" + " = " + Fakultät);

            //    Console.WriteLine("Wollen Sie das Programm neu starten?(J/N)");
            //    string nochmal = Console.ReadLine();

            //    if (nochmal == "N" || nochmal == "n")
            //    {
            //        durchlauf = false;
            //    }
            //    else if (nochmal == "J" || nochmal == "j")
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("Sie haben ein falsches Zeichen eingegeben! Das Programm wird beendet");
            //        durchlauf = false;
            //    }

            //} while (durchlauf);


            #endregion

            #region Quaderberechnung 
            //bool durchlauf = true;
            //bool keineZahl = true;

            //do
            //{
            //    Console.WriteLine("Gleich musst Du die Breite, Länge und Höhe eines Quaders eingeben:");

            //    Console.WriteLine("Gib die Breite ein:");
            //    string breite;
            //    double Breite;
            //    do
            //    {
            //        breite = Console.ReadLine();
            //        if (!double.TryParse(breite, out Breite))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", breite);
            //        }
            //        else
            //        {
            //            keineZahl = false;
            //        }
            //    } while (keineZahl);

            //    keineZahl = true;

            //    Console.WriteLine("Jetzt gib die Länge ein:");
            //    string länge;
            //    double Länge;
            //    do
            //    {
            //        länge = Console.ReadLine();
            //        if (!double.TryParse(länge, out Länge))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", länge);
            //        }
            //        else
            //        {
            //            keineZahl = false;
            //        }
            //    } while (keineZahl);

            //    keineZahl = true;


            //    Console.WriteLine("Und jetzt gib noch die Höhe ein:");
            //    string höhe;
            //    double Höhe;
            //    do
            //    {
            //        höhe = Console.ReadLine();
            //        if (!double.TryParse(höhe, out Höhe))
            //        {
            //            Console.WriteLine("{0} ist keine Zahl!", höhe);
            //        }
            //        else
            //        {
            //            keineZahl = false;
            //        }
            //    } while (keineZahl);

            //    keineZahl = true;


            //    Console.WriteLine("Wollen sie das Volumen(V), die Oberfläche(O) oder die Raumdiagonale(R) berechnen?");
            //    string berechnung = Console.ReadLine();

            //    if (berechnung == "V" || berechnung == "v")
            //    {
            //        double Volumen = Breite * Länge * Höhe;
            //        Console.WriteLine("Das Volumen deines Quaders ist:" + Volumen);
            //    }
            //    else if (berechnung == "O" || berechnung == "o")
            //    {
            //        double Oberfläche = (Höhe * Länge + Höhe * Breite + Länge * Breite) * 2;
            //        Console.WriteLine("Die Oberfläche deines Quaders ist:" + Oberfläche);

            //    }
            //    else if (berechnung == "R" || berechnung == "r")
            //    {
            //        double Raumdiagonale = Math.Sqrt(Math.Pow(Breite, 2) + Math.Pow(Länge, 2) + Math.Pow(Höhe, 2));
            //        Console.WriteLine("Die Raumdiagonale deines Quaders ist:" + Raumdiagonale);
            //    }

            //    Console.WriteLine("Wollen Sie das Programm neu starten?(J/N)");
            //    string nochmal = Console.ReadLine();

            //    if (nochmal == "N" || nochmal == "n")
            //    {
            //        durchlauf = false;
            //    }
            //    else if (nochmal == "J" || nochmal == "j")
            //    {
            //        durchlauf = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Sie haben ein falsches Zeichen eingegeben, deswegen wird das Programm jetzt beendet");
            //        durchlauf = false;
            //    }
            //} while (durchlauf);

            #endregion

            #region Zinssatz
            bool durchlauf = true;
            do
            {
                Console.WriteLine("Geben sie ein Betrag ein:");
                string betrag;
                double Betrag = 0;
                bool keineZahl = true;

                do
                {
                    betrag = Console.ReadLine();
                    if (!double.TryParse(betrag, out Betrag))
                    {
                        Console.WriteLine("{0} ist keine Zahl", betrag);
                        Console.WriteLine("Bitte versuchen Sie es erneut: ");
                    }
                    else if (Betrag <= 0)
                    {
                        Console.WriteLine("Ihr Betrag ist kleiner oder gleich 0, bitte geben Sie einen Betrag über 0 ein: ");
                    }
                    else
                    {
                        keineZahl = false;
                    }
                } while (keineZahl);

                keineZahl = true;

                Console.WriteLine("Geben sie den Zinssatz ein:");
                string Zinssatz;
                double zinssatz = 0;

                do
                {
                    Zinssatz = Console.ReadLine();
                    if (!double.TryParse(Zinssatz, out zinssatz))
                    {
                        Console.WriteLine("{0} ist keine Zahl", Zinssatz);
                        Console.WriteLine("Bitte versuchen Sie es erneut: ");
                    }
                    else if (zinssatz > 20)
                    {
                        Console.WriteLine("Ihr Zinsatz darf nicht größer als 20 sein!, versuchen Sie es erneut: ");
                    }
                    else
                    {
                        keineZahl = false;
                    }
                } while (keineZahl);
                keineZahl = true;

                Console.WriteLine("Nach wievielen Jahren Zinsen wollen sie den Betrag berechnen");
                string Jahre;
                double jahre;

                do
                {
                    Jahre = Console.ReadLine();
                    if (!double.TryParse(Jahre, out jahre))
                    {
                        Console.WriteLine("{0} ist keine Zahl", Jahre);
                        Console.WriteLine("Bitte versuchen Sie es erneut: ");
                    }
                    else
                    {
                        keineZahl = false;
                    }
                } while (keineZahl);
                keineZahl = true;

                for (int i = 0; i < jahre; i++)
                {
                    Betrag = Betrag * zinssatz / 100 + Betrag;
                }
                

                Betrag = Math.Round(Betrag, 2);

                Console.WriteLine("Ihr Betrag nach 3 Jahren mit Zinsen ist:" + Betrag);

                Console.WriteLine("Wollen Sie das Programm neustarten?(J/N)");
                string nochmal = Console.ReadLine();

                if (nochmal == "N" || nochmal == "n")
                {
                    durchlauf = false;
                }
                else if (nochmal == "J" || nochmal == "j")
                {

                }
                else
                {
                    Console.WriteLine("Sie haben ein falsches zeichen eingegeben, das Programm wird beendet!");
                    durchlauf = false;
                }
            } while (durchlauf);


            #endregion
        }
    }
}