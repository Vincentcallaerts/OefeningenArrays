using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening7
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] getallen1 = new int[5];
            int[] getallen2 = new int[5];
            int[] getallen3 = new int[5];
            Console.WriteLine("Eerste 5 getallen");

            for (int i = 0; i < getallen1.Length; i++)
            {
                getallen1[i] = InputInt();
            }

            Console.WriteLine("Tweede 5 getallen");

            for (int i = 0; i < getallen2.Length; i++)
            {
                getallen2[i] = InputInt();
            }

            for (int i = 0; i < getallen1.Length; i++)
            {
                getallen3[i] = getallen1[i] + getallen2[i];
                Console.WriteLine(getallen3[i]);
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
