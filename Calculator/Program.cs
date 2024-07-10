using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press The First Number: ");
            int numri1 = int.Parse(Console.ReadLine());
            Console.Write("Pres The Second Number: ");
            int numri2 = int.Parse(Console.ReadLine());
            Console.Write("Pick An Operator +, -, *, / : ");
            string operatori = Console.ReadLine();

            if (operatori == "+")
            {
                int rezultati = numri1 + numri2;
                Console.WriteLine("Equals: " + rezultati);
            }
            else if (operatori == "-")
            {
                int rezultati = numri1 - numri2;
                Console.WriteLine("Equals: " + rezultati);
            }
            else if (operatori == "*")
            {
                int rezultati = numri1 * numri2;
                Console.WriteLine("Equals: " + rezultati);
            }
            else if (operatori == "/")
            {
                int rezultati = numri1 / numri2;
                Console.WriteLine("Equals: " + rezultati);
            }

            Console.WriteLine("");
            Console.WriteLine("Press Any Key To Close It!");

            Console.ReadKey();  
        }
    }
}
