using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening12
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] puzzeltje = { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 },{ 10, 11, 12 }, { 13, 14, 0 } };
            PrintPuzzel(puzzeltje);
            Move(4, puzzeltje);
            Console.Clear();
            Console.ReadLine();
            PrintPuzzel(puzzeltje);
            Move(4, puzzeltje);
            Console.ReadLine();
            PrintPuzzel(puzzeltje);
            Move(4, puzzeltje);
            PrintPuzzel(puzzeltje);
            Move(4, puzzeltje);
            Console.ReadLine();
        }
        static int InputInt()
        {

            Console.Write("Geeft 8 voor omhoog 2 voor naar beneden 4 voor links of 6 voor rechts:");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (getal == 2 || getal == 4 || getal == 6 || getal == 8)
            {
                return getal;
            }
            return InputInt();

        }
        static void Move(int getal,int[,] puzzeltje) 
        {
            switch (getal)
            {
                // Down
                case 2:
                    
                    break;
                // Left
                case 4: 
                    
                    break;
                // Right
                case 6: 
                    
                    break;
                //Up
                case 8:
                    
                    break;
                default:
                    break;
            }
        }
        static void PrintPuzzel(int[,] puzzeltje)
        {

            for (int i = 0; i < puzzeltje.Length/3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < puzzeltje.Length/5; j++)
                {
                    if (puzzeltje[i, j] == 0)
                    {
                        Console.Write("|@|");
                    }
                    else
                    {
                        Console.Write(puzzeltje[i, j] + "\t");
                    }
                    
                }
            }

        }
        static void CheckMove(int getal, int[,] puzzeltje) 
        {
            for (int i = 0; i < puzzeltje.Length / 3; i++)
            {
                
                for (int j = 0; j < puzzeltje.Length / 5; j++)
                {
                    if (puzzeltje[i,j] == 0)
                    {
                        if (getal == 2)
                        {
                            if (j != 0)
                            {

                            }
                        }
                        if (getal == 4)
                        {

                        }
                        if (getal == 6)
                        {

                        }
                        if (getal == 8)
                        {

                        }
                    }
                }
            }
        }
    }
}
