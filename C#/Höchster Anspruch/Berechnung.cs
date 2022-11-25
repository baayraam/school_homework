namespace Taschenrechner
{
    internal class Berechnung
    {
        public static double Berechnungen(double aktuellerwert = 0)
        {
            Console.WriteLine("Moin willkommen zum Taschenrechner");

            #region nur 2 Zahlen
            double Zahl1 = 0;

            Console.Clear();
            Zahl1 = Zahleneingabe();

            string rechenoperator = "";
            rechenoperator = Rechenperatoreigabe();

            double Zahl2 = 0 ;
            if (rechenoperator == "Q" || rechenoperator == "!" || rechenoperator == "Qu")
            {
                aktuellerwert = QFQUMethode(Zahl1, rechenoperator, aktuellerwert);
            }
            else
            {
                Zahl2 = Zahleneingabe();

                aktuellerwert = Rechnungen(Zahl1, Zahl2, rechenoperator, aktuellerwert);
            }
            #endregion


            #region EineWeitereZahlHinzufügen

            rechenoperator = Rechenperatoreigabe2();
            do
            {
                if (rechenoperator == "+" || rechenoperator == "-" || rechenoperator == "*" || rechenoperator == "/" || rechenoperator == "%" || rechenoperator == "R" || rechenoperator == "Re")
                {
                    do
                    {
                        Zahl2 = Zahleneingabe();

                        Console.Clear();
                        aktuellerwert = Rechnungen(aktuellerwert, Zahl2, rechenoperator, aktuellerwert);

                        rechenoperator = Rechenperatoreigabe2();
                    } while (rechenoperator == "+" || rechenoperator == "-" || rechenoperator == "*" || rechenoperator == "/" || rechenoperator == "%" || rechenoperator == "R" || rechenoperator == "Re");
                }
                else if (rechenoperator == "Q" || rechenoperator == "!" || rechenoperator == "Qu")
                {
                    aktuellerwert = QFQUMethode(aktuellerwert, rechenoperator, aktuellerwert);

                    rechenoperator = Rechenperatoreigabe2();
                }
                else if (rechenoperator == "=")
                {

                }
            } while (rechenoperator == "+" || rechenoperator == "-" || rechenoperator == "*" || rechenoperator == "/" || rechenoperator == "%" || rechenoperator == "Q" || rechenoperator == "R" || rechenoperator == "Re" || rechenoperator == "!" || rechenoperator == "Qu");

            Console.WriteLine("\nDas Ergebnis aus Ihrer Rechnung ist: {0}", aktuellerwert);
            #endregion
            return aktuellerwert;
        }

        public static void Taschenrechnerstarten()
        {
            bool Durchlauf = true;
            do
            {
                Console.Clear();
                bool falscheEingabe = true;
                string WelchenRechner;
                do
                {
                    Console.WriteLine("Wollen sie Den Taschenrechner starten? (J/N)");
                    WelchenRechner = Console.ReadLine();

                    if (WelchenRechner == "J" || WelchenRechner == "j" || WelchenRechner == "N" || WelchenRechner == "n")
                    {
                        falscheEingabe = false;
                    }
                    else
                    {
                        Console.WriteLine("Sie haben ein Falsches Zeichen eingegeben: {0}", WelchenRechner);
                    }
                } while (falscheEingabe);
                #region Berechnungen
                string nochmalRechnen;
                switch (WelchenRechner)
                {
                    case "J":
                        int Länge = 1;
                        double[] Ergebnis = new double[50];
                        for (int i = 0; i < Länge; i++)
                        {
                            Ergebnis[i] = Berechnungen();

                            Console.WriteLine("Wollen sie den Taschenrechner nochmal durchlaufen? (J/N)");
                            nochmalRechnen = Console.ReadLine();
                            if (nochmalRechnen == "J" || nochmalRechnen == "j")
                            {
                                Länge++;
                                Console.Clear();
                            }
                            else
                            {
                                for (int J = 0; J <= i; J++)
                                {
                                    Console.WriteLine("Ihr Ergebnis Ihres " + (J + 1) + ". Durchlaufes war: " + Ergebnis[J]);
                                }
                            }
                        }
                        break;
                    case "N":
                        Console.Clear();
                        Console.WriteLine("Alles Klar tschüs!");
                        break;

                    default:
                        break;
                }
                #endregion
                #region Programmwiederholung
                bool falschesZeichen = true;
                do
                {
                    Console.WriteLine("Wollen Sie das Programm wiederholen? (J/N)");
                    string wiederholung = Console.ReadLine();
                    if (wiederholung == "J" || wiederholung == "j")
                    {
                        Durchlauf = true;

                        falschesZeichen = false;
                    }
                    else if (wiederholung == "N" || wiederholung == "n")
                    {
                        Durchlauf = false;
                        falschesZeichen = false;
                    }
                    else
                    {
                    }
                } while (falschesZeichen);
                #endregion
            } while (Durchlauf);
        }

        public static double Zahleneingabe()
        {
            string zahl;
            double Zahl;
            bool keineZahl = true;
            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein:");
                zahl = Console.ReadLine();
                if (!double.TryParse(zahl, out Zahl))
                {
                    Console.WriteLine("System.FormatException!! {0} ist keine Zahl, bitte geben Sie eine Zahl ein:", zahl);
                }
                else
                {
                    keineZahl = false;
                }
            } while (keineZahl);

            return Zahl;
        }

        public static string Rechenperatoreigabe()
        {
            string rechenoperator;
            bool keinRechenoperator = true;
            do
            {
                Console.WriteLine("Was wollen sie rechnen?\n+ Für die Addition\n - Für die Subtraktion\n * Für die Multiplikation \n / Für die Divsion \n % Für Prozentrechnung \n Q Für Quadratwurzel \n ! Für die Fakultät \n Qu Für die Quersumme \n R Für die Berechnung einen Rabattes \n Re Für die Berechnung eines Restes");
                rechenoperator = Console.ReadLine();
                if (rechenoperator == "+" || rechenoperator == "-" || rechenoperator == "*" || rechenoperator == "/" || rechenoperator == "%" || rechenoperator == "Q" || rechenoperator == "R" || rechenoperator == "Re" || rechenoperator == "!" || rechenoperator == "Qu")
                {
                    keinRechenoperator = false;
                }
                else
                {
                    Console.WriteLine("{0} Sie haben ein Falsches Zeichen eingegeben! Bitte Geben sie ein +, -, *, /, %, Q, R, !, Qu, Q oder Re ein: ", rechenoperator);
                }
            } while (keinRechenoperator);

            return rechenoperator;
        }

        public static string Rechenperatoreigabe2()
        {
            string rechenoperator;
            bool keinRechenoperator = true;
            do
            {
                Console.WriteLine("Was wollen sie rechnen?\n+ Für die Addition\n - Für die Subtraktion\n * Für die Multiplikation \n / Für die Divsion \n % Für Prozentrechnung \n Q Für Quadratwurzel \n ! Für die Fakultät \n Qu Für die Quersumme \n R Für die Berechnung einen Rabattes \n Re Für die Berechnung eines Restes\n = Um das Ergebnis auszugeben");
                rechenoperator = Console.ReadLine();
                if (rechenoperator == "+" || rechenoperator == "-" || rechenoperator == "*" || rechenoperator == "/" || rechenoperator == "%" || rechenoperator == "Q" || rechenoperator == "R" || rechenoperator == "Re" || rechenoperator == "!" || rechenoperator == "Qu" || rechenoperator == "=")
                {
                    keinRechenoperator = false;
                }
                else
                {
                    Console.WriteLine("{0} Sie haben ein Falsches Zeichen eingegeben! Bitte Geben sie ein +, -, *, /, %, Q, R, !, Qu, Q, Re oder = ein: ", rechenoperator);
                }
            } while (keinRechenoperator);

            return rechenoperator;
        }

        public static double QFQUMethode(double Zahl1, string rechenoperator, double aktuellerwert)
        {
            switch (rechenoperator)
            {
                case "Q":
                    aktuellerwert = Math.Sqrt(Zahl1);
                    Console.Clear();
                    Console.WriteLine("Die Wurzel aus {0} = {1}", Zahl1, aktuellerwert);
                    break;
                case "!":
                    double Fakultät = 1;
                    for (int i = 1; i <= Zahl1; i++)
                    {
                        Fakultät *= i;
                    }
                    aktuellerwert = Fakultät;

                    Console.Clear();
                    Console.WriteLine("{0}! = {1}", Zahl1, aktuellerwert);
                    break;
                case "Qu":
                    double result = 0;
                    if (Zahl1 > 0)
                    {
                        while (Zahl1 > 0)
                        {
                            result += Zahl1 % 10;
                            Zahl1 /= 10;
                        }
                    }
                    aktuellerwert = Math.Floor(result);
                    Console.Clear();
                    Console.WriteLine("Die Quersumme von {0} = {1}", Zahl1, aktuellerwert);
                    break;
                default:
                    break;
            }

            return aktuellerwert;
        }

        public static double Rechnungen(double Zahl1, double Zahl2, string rechenoperator, double aktuellerwert)
        {
            switch (rechenoperator)
            {
                case "+":
                    aktuellerwert = Zahl1 + Zahl2;
                    Console.Clear();
                    Console.WriteLine("{0} + {1} = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "-":
                    aktuellerwert = Zahl1 - Zahl2;

                    Console.Clear();
                    Console.WriteLine("{0} - {1} = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "/":
                    aktuellerwert = Zahl1 / Zahl2;
                    Console.Clear();
                    Console.WriteLine("{0} : {1} = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "*":
                    aktuellerwert = Zahl1 * Zahl2;
                    Console.Clear();
                    Console.WriteLine("{0} * {1} = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "%":
                    aktuellerwert = (Zahl2 / 100) * Zahl1;
                    Console.Clear();
                    Console.WriteLine("({1} : 100) * {0} = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "R":
                    aktuellerwert = Zahl1 * (1 - Zahl2 / 100);
                    Console.Clear();
                    Console.WriteLine("{0} *(1 - {1} : 100) = {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
                case "Re":
                    aktuellerwert = Zahl1 % Zahl2;
                    Console.Clear();
                    Console.WriteLine("{0} / {1} = " + Zahl1 / Zahl2 +" Rest ist {2}", Zahl1, Zahl2, aktuellerwert);
                    break;
            }
            return aktuellerwert;
        }
    }
}
