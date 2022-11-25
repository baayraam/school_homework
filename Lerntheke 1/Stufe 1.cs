// See https://aka.ms/new-console-template for more information

int[] zahlen = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11};

for (int i = 0; i < zahlen.Length; i++)
{
    Console.WriteLine(zahlen[i]);
}


for (int i = 0; i < zahlen.Length; i++)
{
    zahlen[i] += 1;
    Console.WriteLine(zahlen[i]);
}

