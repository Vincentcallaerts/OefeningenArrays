using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening11
{
    class Program
    {
        static void Main(string[] args)
        {

            string naam,telefoonnummer,postcode;
            bool running = true;
            do
            {

                Console.Write("geef je naam in: ");
                naam = InputString();      
                
                Console.Write("geef je telefoonnummer in: ");
                telefoonnummer = InputString();
                Console.Write("geef je postcode in: ");
                postcode = InputString();

                Console.WriteLine($"Je nieuwe passwoord is {GenPasswd(naam,telefoonnummer,postcode)}");
                

            } while (running);
            
        }
        static string InputString() 
        {
            string temp = Console.ReadLine();
            if (temp.Substring(0,1) == "0")
            {
                temp = temp.Substring(1, temp.Length-1);
            }
            return temp;
        }
        static string GenPasswd(string naam, string telefoonnummer,string postcode ) 
        {

            string password = "";
            password += naam[1].ToString().ToLower();
            password += naam[0].ToString().ToUpper();
            password += telefoonnummer.Substring(0,2);
            int temp = (int)Math.Round(Math.Pow(Convert.ToInt32(postcode.Substring(0,1)), 2));
            password += Convert.ToString(temp);

            return password;
        }
        static bool StopRunning()
        {
            Console.WriteLine("Type stop voor te stoppen");
            
            if (InputString().ToLower() == "stop")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
