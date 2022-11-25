using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehr_sterne
{
    class Program
    {
        static void Main(string[] args)
        {
            
            		bool durchlauf = true;
			bool keineZahl = true;
			do
			{
				Console.WriteLine("Geben sie eine Zahl ein:");
				string N;
				double n;
				
				do
				{
					N = Console.ReadLine();
					if (!double.TryParse(N, out n))
					{
						Console.WriteLine("{0} ist keine Zahl! \n Versuchen sie es erneut!", N);
					}
					else
					{
						if (n <= 0)
						{
							Console.WriteLine("Ihre Zahl darf nicht kleiner als 0 oder gleich 0 sein!!");
						}
						else
						{
							keineZahl = false;
						}
					}
				}
				while (keineZahl);
				
				keineZahl = true;
				for (int i = 1; i <= n; i++)
				{
					Console.WriteLine("***");
				}

				Console.WriteLine("Geben Sie noch eine Zahl ein:");
				string M;
				double m;
				
				do
				{
					M = Console.ReadLine();
					if (!double.TryParse(M, out m))
					{
						Console.WriteLine("{0} ist keine Zahl! \n Versuchen sie es erneut!", M);
					}
					else
					{
						if (n <= 0)
						{
							Console.WriteLine("Ihre Zahl darf nicht kleiner als 0 oder gleich 0 sein!!");
						}
						else
						{
							keineZahl = false;
						}
					}
				}
				while (keineZahl);
				for (int i = 1; i <= n; i++)
				{
					Console.WriteLine("");
					for (int k = 1; k <= m; k++)
					{
						Console.Write("*");
					}
				}

				Console.WriteLine("Wollen Sie das Programm nochmal starten?(J/N);string nochmal = Console.ReadLine()");
						string nochmal = Console.ReadLine();
				if (nochmal == "j" || nochmal == "J")
				{
				}
				else
				{
					durchlauf = false;
				}
			}
			while (durchlauf);
           
        }
    }
}
