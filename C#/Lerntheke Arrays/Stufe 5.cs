namespace Stufe_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] z = new int[,] { { 1, 1 }, { 2, 3 }, { 10, 5 } };

            for (int i = 0; i < z.GetLength(0); i++) 
            {   for (int j = 0; j < z.GetLength(1); j++)
                {
                    z[i, j] -= 69;
                    Console.WriteLine(z[i, j]); 
                }
            }

            //das korrekte Programm gibt nun die Zahlen -68, -68, -67,-66,-59 und -64 aus

            Console.ReadKey();
        }
    }
}