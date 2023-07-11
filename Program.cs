using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cCode;
            string lang;
            string choice;
            do
            {
                Console.WriteLine("Enter Country Code");
                cCode = Console.ReadLine().ToLower();
                switch (cCode)
                {
                    case "uk":
                    case "us":
                        {
                            lang = "English";
                            break;
                        }
                    case "af":
                        {
                            lang = "Dari, Pashto";
                            break;
                        }
                    case "in":
                        {
                            lang = "Hindi, ENglish , Tamil, Telugu, Punjabi";
                            break;
                        }
                    case "uae":
                    case "om":
                    case "ksa":
                    case "egypt":

                        {
                            lang = "Arabic";
                            break;
                        }
                    default:
                        {
                            Console.WriteLine($"Sorry!!Your Country {cCode} is not in our DB\n");
                            lang = "Not Found!!!";
                            break;
                        }
                }
                Console.WriteLine("Country Code\t" + "Languages");
                Console.WriteLine("---------------------------");
                Console.WriteLine(cCode + "\t\t" + lang+"\n");
                Console.WriteLine("Do you Wanna continue if yes press y \n To exit press any key");
                choice = Console.ReadLine();


            } while (choice=="y");
            Console.ReadKey();
            

        }
    }
}
