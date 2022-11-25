import java.util.Scanner;

public class TicTacToe
{
    public static Scanner read = new Scanner(System.in);
    static String[] Position = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    public static void main(String[] args) throws Exception 
    {
        String Symbol1Player;
        String Symbol2Player;
        
        System.out.println("\nMoin es wird TicTacToe gespielt!!");
        System.out.println("\n Suchen Sie sich einen Partner!");
        System.out.println("Wie heißt der erste Spieler");
        String Player1 = read.nextLine();

        System.out.println("Wie heißt der zweite Spieler");
        String Player2 = read.nextLine();
        
        TicTacToefeld();
        
        System.out.println(Player1 + " Wollen Sie O oder X sein\n(geben sie O/o oder X/x ein)");

        do
        {
            String abfrage = read.nextLine();

            if(abfrage == "O" || abfrage == "o")
            {
                Symbol1Player = "O";
                Symbol2Player = "X";
                break;
            }
            else if(abfrage == "X" || abfrage == "x")
            {
                Symbol1Player = "X";
                Symbol2Player = "O";
                break;
            }
            else
            {
                System.out.println(abfrage + " ist kein X/x oder O/o!!\n Versuchen Sie es erneut:");
            }
        }while(true);

        System.out.println(Player1 + " hat das Symbol: " + Symbol1Player + "\n" + Player2 + " hat das Symbol: " + Symbol2Player);

        TicTacToefeld();

        boolean gewonnen = true;
        do
        {
            System.out.println(Player1 + " in welchem Feld wollen Sie ihr Symbol platzieren?");
            String welchesFeld = read.nextLine();

            for(int i = 0; i < Position.length; i++)
            {
                if(welchesFeld == Position[i])
                {
                    Position[i] = Symbol2Player;
                }
            }
            System.out.println("\n");

            TicTacToefeld();

            System.out.println("\n");

            DreiSymboleGewonnen(Player1, Player2, Symbol1Player, Symbol2Player, gewonnen);
            
        }while(gewonnen);
    }

    public static void TicTacToefeld()
    {
        System.out.println("");
        System.out.println("   " + Position[0] + "   |   " + Position[1]+"   |   " + Position[2] +"   ");
        System.out.println("  -------------------");
        System.out.println("   " + Position[3] + "   |   " + Position[4]+"   |   " + Position[5] +"   ");
        System.out.println("  -------------------");
        System.out.println("   " + Position[6] + "   |   " + Position[7]+"   |   " + Position[8] +"   ");
        System.out.println("");
    }

    public static void DreiSymboleGewonnen(String Player1, String Player2, String Player1Symbol, String Player2Symbol, boolean gewonnen)
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
                System.out.println(Player1 + " hat gewonnen!!");
                gewonnen = false;
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
                System.out.println(Player2 + " hat gewonnen!!");
                gewonnen = false;
            }
    }
}