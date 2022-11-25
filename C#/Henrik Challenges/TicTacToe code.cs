namespace tictactoe_Henrik_Challenge
{
    internal class Program
    {
        static string[] Position = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        static void Main(string[] args)
        {
            int min = 1;
            int max = 9;

            Random rnd = new Random();

            string Symbol1Player;
            string Symbol2Player;

            string Player2 = "KI";
            Console.WriteLine("\nMoin es wird Tic Tac Toe gespielt auf süß");
            Console.WriteLine(" \nSuchen Sie sich einen Partner!");

            Console.WriteLine("\nWie heißt der erste Spieler?");
            string Player1 = Console.ReadLine();

            Console.WriteLine("Gibt es noch einen weiteren Spieler? (J/N)");
            string weiterenSpieler = Console.ReadLine();

            if (weiterenSpieler == "J" || weiterenSpieler == "j")
            {
                Console.WriteLine("\nAlles klar wie heißt der zweite Spieler?");
                Player2 = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Alles klar Sie spielen jetzt gegen eine KI!");
            }
            

            TicTacToefeld();

            Console.WriteLine(Player1 + " Wollen Sie O oder X sein(geben Sie O/o oder X/x ein)");
            do
            {
                string abfrage = Console.ReadLine();

                if (abfrage == "O" || abfrage == "o")
                {
                    Symbol1Player = "O";
                    Symbol2Player = "X";
                    break;
                }
                else if (abfrage == "X" || abfrage == "x")
                {
                    Symbol1Player = "X";
                    Symbol2Player = "O";
                    break;
                }
                else
                {
                    Console.WriteLine("{0} ist kein X/x oder O/o!! \n Versuchen Sie es erneut:", abfrage);
                }
            } while (true);

            Console.WriteLine("Alles klar {0} hat das Symbol: {1} \n {2} hat das Symbol: {3}", Player1, Symbol1Player, Player2, Symbol2Player);

            string gewonnen = "";
            bool moin = true;
            do
            {
                TicTacToefeld();

                Console.WriteLine("{0} in welchem Feld wollen Sie ihr Symbol plazieren?", Player1);
                string welchesFeld;
                do
                {
                     welchesFeld = Console.ReadLine();


                    if (welchesFeld == "1" || welchesFeld == "2" || welchesFeld == "3" || welchesFeld == "4" ||
                        welchesFeld == "5" || welchesFeld == "6" || welchesFeld == "7" || welchesFeld == "8" ||
                        welchesFeld == "9")
                    {
                        for (int i = 0; i < Position.Length; i++)
                        {
                            if (welchesFeld == Position[i])
                            {
                                Position[i] = Symbol1Player;
                            }
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("{0} ist keine Zahl zwischen 1-9\nVersuchen Sie es erneut: ", welchesFeld);
                    }
                } while (true);
               
                
                TicTacToefeld();

                gewonnen = DreiSymboleInEinerReihe(Player1, Player2, Symbol1Player, Symbol2Player, gewonnen);

                bool KIFeld = true;
                if (gewonnen != "Gewonnen")
                {
                    do
                    {
                        Console.WriteLine("KI wählt ein Feld:");
                        welchesFeld = Convert.ToString(rnd.Next(min, max));

                        for (int i = 0; i < Position.Length; i++)
                        {
                            if (welchesFeld == Position[i])
                            {
                                Position[i] = Symbol2Player;
                                KIFeld = false;
                            }
                        }
                    } while (KIFeld);
                    gewonnen = DreiSymboleInEinerReihe(Player1, Player2, Symbol1Player, Symbol2Player, gewonnen);
                }

                if (gewonnen == "Gewonnen")
                {
                    moin = false;
                }
                Console.WriteLine("\n");
            } while (moin);
        }

        public static void TicTacToefeld()
        {
            Console.WriteLine("\n");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", Position[0], Position[1], Position[2]);
            Console.WriteLine("  -------------------");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", Position[3], Position[4], Position[5]);
            Console.WriteLine("  -------------------");
            Console.WriteLine("   {0}   |   {1}   |   {2}   ", Position[6], Position[7], Position[8]);
            Console.WriteLine("\n");

        }

        public static string DreiSymboleInEinerReihe(string Player1, string Player2, string Player1Symbol, string Player2Symbol, string Gewonnen)
        {
            if (Position[0] == Player1Symbol && Position[1] == Player1Symbol && Position[2] == Player1Symbol ||
                Position[3] == Player1Symbol && Position[4] == Player1Symbol && Position[5] == Player1Symbol ||
                Position[6] == Player1Symbol && Position[7] == Player1Symbol && Position[8] == Player1Symbol ||
                Position[0] == Player1Symbol && Position[3] == Player1Symbol && Position[6] == Player1Symbol ||
                Position[1] == Player1Symbol && Position[4] == Player1Symbol && Position[7] == Player1Symbol ||
                Position[2] == Player1Symbol && Position[5] == Player1Symbol && Position[8] == Player1Symbol ||
                Position[0] == Player1Symbol && Position[4] == Player1Symbol && Position[8] == Player1Symbol ||
                Position[2] == Player1Symbol && Position[4] == Player1Symbol && Position[6] == Player1Symbol)
            {
                Console.WriteLine(Player1 + " hat gewonnen!!");
                Gewonnen = "Gewonnen";
            }
            else if (Position[0] == Player2Symbol && Position[1] == Player2Symbol && Position[2] == Player2Symbol ||
                Position[3] == Player2Symbol && Position[4] == Player2Symbol && Position[5] == Player2Symbol ||
                Position[6] == Player2Symbol && Position[7] == Player2Symbol && Position[8] == Player2Symbol ||
                Position[0] == Player2Symbol && Position[3] == Player2Symbol && Position[6] == Player2Symbol ||
                Position[1] == Player2Symbol && Position[4] == Player2Symbol && Position[7] == Player2Symbol ||
                Position[2] == Player2Symbol && Position[5] == Player2Symbol && Position[8] == Player2Symbol ||
                Position[0] == Player2Symbol && Position[4] == Player2Symbol && Position[8] == Player2Symbol ||
                Position[2] == Player2Symbol && Position[4] == Player2Symbol && Position[6] == Player2Symbol)
            {
                Console.WriteLine(Player2 + " hat gewonnen!!");
                Gewonnen = "Gewonnen";
            }
            return Gewonnen;
        }
    }
}
