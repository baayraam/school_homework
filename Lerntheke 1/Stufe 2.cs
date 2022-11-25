// See https://aka.ms/new-console-template for more information
int[] Zahlen = new int[] { 1, 2, 3, 4, 5, 6, 0, 8, 9, 10, 11 };

for (int i = 0; i < Zahlen.Length; i++)
{
    Console.WriteLine(Zahlen[i]);
}

Console.WriteLine("\n");

for (int i = 0; i < Zahlen.Length; i++)
{
    if (Zahlen[i] != i)
    {
        Zahlen[i] = i;
    }
  
}

for (int i = 0; i < Zahlen.Length; i++)
{
    Console.WriteLine(Zahlen[i]);
}