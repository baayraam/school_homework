import java.util.Scanner;

public class App {

    public static void main(String[] args) throws Exception 
    {
        char[] Buchstaben = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

        Scanner read = new Scanner(System.in);

        String dieseWort = "";
        System.out.println("Gib ein Wort ein:");
        String readWord = read.nextLine();


        for(int i = 0; i < readWord.length(); i++)
        {
            for(int j = 0; j < Buchstaben.length;j++)
            {
                System.out.println(dieseWort + Buchstaben[j]);

                boolean istBuchstabe = readWord.charAt(i) == Buchstaben[j];

                if(istBuchstabe == true)
                {
                    dieseWort = dieseWort + Buchstaben[j];
                    break;
                }
            }
        }
        System.out.println("Wort ist: " + dieseWort);
    }

}
