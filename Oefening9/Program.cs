using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening9
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
            
            while (true)
            {
                Console.Write("Het volgende getal verwijderd iets in de array als het er is");
                DoTheThing(InputInt(),getallen);
                Console.Clear();
            }
            

            //Console.ReadLine();

        }
        static int InputInt()
        {

            Console.Write(" Input getal:");
            int getal = Convert.ToInt32(Console.ReadLine());
            return getal;

        }
        static void DoTheThing(int getal,int[] getallen) 
        {

            if (getallen.Contains(getal))
            {
                for (int i = 0; i < getallen.Length; i++)
                {
                    if (getal == getallen[i])
                    {
                        for (int j = i; j < getallen.Length; j++)
                        {
                            if (j == getallen.Length-1)
                            {
                                getallen[j] = -1;
                            }
                            else
                            {
                                getallen[j] = getallen[j+1];
                            }
                        }
                    }
                }
            }
            else
            {
                if (getallen.Contains(-1))
                {
                    for (int i = 0; i < getallen.Length; i++)
                    {
                        if (getallen[i] == -1)
                        {
                            getallen[i] = getal;
                            break;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("verwijder eerst een getal");
                }
            }
            for (int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine($"{getallen[i]}");
            }
        }
    }
}
