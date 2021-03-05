using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vraag = { "vraag1", "vraag2", "vraag3", "vraag4", "vraag5", "vraag6" };
            int[] antwoord = new int[6];

            for (int i = 0; i < vraag.Length; i++)
            {
                Console.WriteLine(vraag[i]);
                antwoord[i] = InputInt();
            }
            for (int i = 0; i < vraag.Length; i++)
            {
                Console.WriteLine($"{vraag[i]} had als antwoord: {antwoord[i]}");
            }
            Console.ReadLine();
        }
        static int InputInt()
        {

            Console.Write("Input antwoord: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;

        }
    }
}
