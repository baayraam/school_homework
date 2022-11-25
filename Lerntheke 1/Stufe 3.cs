namespace Stufe_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nocheineZahl;

            int[] Zahlen = new int[10];

            Console.WriteLine("Sie müssen nun 10 Zahlen eingeben");

            for (int i = 0; i < Zahlen.Length; i++)
            {
                Console.WriteLine(i+1 + ". Zahl");
                Zahlen[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
            Console.WriteLine("Diese Zahlen hast du eingegeben:");

            for (int i = 0; i < Zahlen.Length; i++)
            {
                Console.WriteLine(i + 1 +  ". Zahl = " + Zahlen[i]);
            }

            Console.WriteLine("\n");

            bool zahlenaustauschen = true;
            do
            {
                Console.WriteLine("Wollen sie eine Zahl austauschen?");
                
                string Zahlaustauschen = Console.ReadLine();

                if (Zahlaustauschen == "Ja" || Zahlaustauschen == "ja")
                {
                    Console.WriteLine("Welche Zahl wollen sie austauschen?");
                    int welcheZahl = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Mit welcher Zahl wollen sie die vorherige austauschen?");
                    int Zahltausch = Convert.ToInt32(Console.ReadLine());

                    if (Zahltausch == Zahlen[welcheZahl])
                    {
                        Console.WriteLine("Die Zahl ist die gleiche wie davor und wird trotzdem gespeichert");
                    }
                    else
                    {
                        Console.WriteLine("Zahl wurde überschrieben");
                        Zahlen[welcheZahl] = Zahltausch;

                        for (int i = 0; i < Zahlen.Length; i++)
                        {
                            Console.WriteLine(i + 1 + ". Zahl = " + Zahlen[i]);
                        }
                    }

                    Console.WriteLine("Wollen sie noch eine Zahl tauschen?");
                    nocheineZahl = Console.ReadLine();
                    if (nocheineZahl == "ja" || nocheineZahl == "Ja")
                    {
                        zahlenaustauschen = true;
                    }
                    else
                    {
                        Console.WriteLine("Das Programm wird beendet!");
                        zahlenaustauschen = false;
                    }
                }
                else
                {
                    Console.WriteLine("Wollen sie noch eine Zahl tauschen?");
                    nocheineZahl = Console.ReadLine();
                    if (nocheineZahl == "ja" || nocheineZahl == "Ja")
                    {
                        zahlenaustauschen = true;
                    }
                    else
                    {
                        Console.WriteLine("Das Programm wird beendet!");
                        zahlenaustauschen = false;
                    }
                }
            }while(zahlenaustauschen == true);
            
        }

    }
}