using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geben sie Zahl1 ein: ");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geben sie Zahl2 ein: ");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition: " + Addiere(Zahl1, Zahl2));
            Console.WriteLine("Subtraktion: " + Subtrahiere(Zahl1, Zahl2));
            Console.ReadKey();

        }
        static int Addiere(int Zahl1, int Zahl2)
        {

            return (Zahl1 + Zahl2);
        }

        static int Subtrahiere(int Zahl1, int Zahl2)
        {
            return (Zahl1 - Zahl2);
        }
    }
}
