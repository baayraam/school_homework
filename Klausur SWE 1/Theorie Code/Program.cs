namespace Klausur_1_Theorie_Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable für die einzugebenden Zahlenwerte durch den Nutzer
            double zahl1, zahl2, ergebnis = 0;

            //Variable für das Rechenzeichen 
            string operand;

            //Aufforderung an den Nutzer eine Zahl einzugeben, welche anschließend in die erste Variable umkonvertiert und gespeichert wird
            Console.WriteLine("Bitte geben Sie die erste Zahl ein: ");
            zahl1 = Convert.ToDouble(Console.ReadLine());

            //Aufforderung an den Nutzer eine zweite Zahl einzugeben, welche anschließend in die zweite Variable umkonvertiert und gespeichert wird
            Console.WriteLine("Bitte geben Sie die zweite Zahl ein: ");
            zahl2 = Convert.ToDouble(Console.ReadLine());

            //Aufforderung an den Nutzer eine Rechenoperanden einzugeben, welche anschließend in die Variable für das Rechenzeichen gespeichert wird
            Console.WriteLine("Bitte wählen Sie den Operanden aus: ");
            operand = Console.ReadLine();

            // Hier kommt der Code für die Berechnung:
            switch (operand)
            {
                //wenn der Benutzer + eingibt also addieren will, dann wird aber Subtrahiert und die Falsche rechnung in der Console ausgegeben
                case "+":
                    Console.WriteLine("{0} - {1} = {2}", zahl1, zahl2, ergebnis);
                    ergebnis = zahl1 - zahl2;
                    break;
                //wenn der Benutzer - eingibt also subtrahieren will, dann wird aber dividiert und die Falsche rechnung in der Console ausgegeben
                case "-":
                    Console.WriteLine("{0} : {1} = {2}", zahl1, zahl2, ergebnis);
                    ergebnis = zahl1 / zahl2;
                    break;
                //wenn der Benutzer/  eingibt also dividieren will, dann wird aber multipliziert und die Falsche rechnung in der Console ausgegeben
                case "/ ":
                    Console.WriteLine("{0} * {1} = {2} ", zahl1, zahl2, ergebnis);
                    ergebnis = zahl1 * zahl2;
                    break;
                //wenn der Benutzer * eingibt also multiplizieren will, dann wird aber addiert und die Falsche rechnung in der Console ausgegeben
                case "*":
                    Console.WriteLine("{ 0} + {1} = {2}", zahl1, zahl2, ergebnis);
                    ergebnis = zahl1 + zahl2;
                    break;

            }
        }
    }
}