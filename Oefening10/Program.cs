using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening10
{
    class Program
    {
        static void Main(string[] args)
        {

            double [,] prijsPerPostcode = { { 2800, 2000, 1982, 2640 },{ 2,4,5,9} };
            double gewicht;
            int postcode;
            
            Console.WriteLine(prijsPerPostcode.Length);
            while (true)
            {
                Console.Write("Wat is het gewicht van je pakje: ");
                gewicht = InpuDouble();
                Console.Write("Naar welke postcode wil je het vervoeren: ");
                postcode = InputInt(prijsPerPostcode);

                Console.WriteLine($"Dit zal {OutputTotaal(prijsPerPostcode,gewicht,postcode)} kosten.");
            }
            

        }

        static int InputInt(double [,] prijsPerPostcode)
        {

            Console.Write("Input postcode:");
            int getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < prijsPerPostcode.Length/2; i++)
            {
                if (prijsPerPostcode[0,i] == getal)
                {
                    return getal;
                }
            }
            Console.Write("Daar leveren wij niet kan je een andere postcode proberen? ");
            return InputInt(prijsPerPostcode);

        }
        static double InpuDouble()
        {

            Console.Write("Input gewicht:");
            double getal = Convert.ToDouble(Console.ReadLine());
            return getal;

        }
        static double OutputTotaal(double[,] prijsPerPostcode,double gewicht,double postcode)
        {
           
            for (int i = 0; i < prijsPerPostcode.Length / 2; i++)
            {
                if (prijsPerPostcode[0, i] == postcode)
                {
                    return gewicht*prijsPerPostcode[1,i];
                }
            }
            Console.WriteLine("Er ging iets mis");
            return 404;
        }


    }
}
