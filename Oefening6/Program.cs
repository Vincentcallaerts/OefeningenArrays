using System;
using System.Linq;

namespace Oefening6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[10];

            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = InputInt();
            }

            Console.WriteLine(getallen.Sum());
            Console.WriteLine(getallen.Average());
            Console.WriteLine(getallen.Max());
            int getal = InputInt();
            int aantal = 0;
            for (int i = 0; i < getallen.Length; i++)
            {
                if (getallen[i] > getal)
                {
                    aantal++;
                }
            }
            if (aantal != 0)
            {
                Console.WriteLine("Niets groter");
            }

            Console.ReadLine();

        }
        static int InputInt()
        {
            
            Console.Write("Input getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;                     

        }
    }
}
