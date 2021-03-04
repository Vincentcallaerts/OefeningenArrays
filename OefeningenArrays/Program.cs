using System;


namespace OefeningenArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            // oefening 1
            int[] getallen = new int[10];
            for (int i = 0; i < getallen.Length; i++)
            {
                getallen[i] = i + 1;
            }

            for (int i = 0; i < getallen.Length; i++)
            {
                Console.WriteLine($"Getal {i}: {getallen[i]}");
            }
            
            //oefening 2 
            int[] getallen2 = new int[100];
            Console.WriteLine(getallen2.Length);
            for (int i = 0; i < getallen2.Length; i++)
            {
                getallen2[i] = getallen2.Length - i;
            }

            for (int i = 0; i < getallen2.Length; i++)
            {
                Console.Write($"Getal {i}: {getallen2[i]}");
            }
            //oefening 3
            Console.WriteLine();
            char[] alfabet = new char[26];
            int startAlfabet = 97;
            for (int i = 0; i < alfabet.Length; i++)
            {
                alfabet[i] = Convert.ToChar(startAlfabet + i);
            }

            for (int i = 0; i < alfabet.Length; i++)
            {
                Console.Write($"{alfabet[i]}");
            }
            //oefening 4
            int[] getallen3 = new int[20];
            Random random = new Random();

            Console.WriteLine(getallen3.Length);
            for (int i = 0; i < getallen3.Length; i++)
            {
                getallen3[i] = random.Next(100)+1;
            }

            for (int i = 0; i < getallen3.Length; i++)
            {
                Console.WriteLine($"Getal {i}: {getallen3[i]}");
            }
            //oefening 5
            bool[] bools = new bool[30];
            Random random2 = new Random();

            Console.WriteLine(bools.Length);
            for (int i = 0; i < bools.Length; i++)
            {
                if (random2.Next(0,2) == 0)
                {
                    bools[i] = true;
                }
                else
                {
                    bools[i] = false;
                }
                
            }

            for (int i = 0; i < bools.Length; i++)
            {
                Console.WriteLine($"{bools[i]}");
            }


            Console.ReadLine();
        }
    }
}
