using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmnent_3.Ahmed_Benbrahim
{
    class Program
    {
        enum Food
        {
            BURGERFRIES = 1, PIZZA, GARDENSALAD, WINGSFRIES, GREEKSALAD, EXIT
        }
        static void Main(string[] args)
        {
            int MenuChoices = 0;
            string Menu;
            while (MenuChoices != 6)
            {
                Console.WriteLine("==========================MENU=========================");
                Console.WriteLine("From the Menu below, Choose what you would like to eat ");
                Console.WriteLine("=======================================================");
                Console.Write("\n");
                Console.WriteLine("1 - Burger & Fries ");
                Console.WriteLine("2 - Pizza ");
                Console.WriteLine("3 - Garden Salad ");
                Console.WriteLine("4 - Wings & Fries ");
                Console.WriteLine("5 - Greek Salad");
                Console.WriteLine("6 - Exit");
                Console.Write("\n");

                Console.WriteLine("Please make your selection (1 to 5) And 6 to Exit");


                Console.WriteLine("Please Enter your Choice: ");

                Menu = Console.ReadLine();
                Console.Write("\n");
                MenuChoices = Convert.ToInt32(Menu);

                switch ((Food)(MenuChoices))
                {
                    case Food.BURGERFRIES:
                        Console.WriteLine("You chose Burger & Fries");
                        break;
                    case Food.PIZZA:
                        Console.WriteLine("You chose Pizza");
                        break;
                    case Food.GARDENSALAD:
                        Console.WriteLine("You chose Garden Salad");
                        break;
                    case Food.WINGSFRIES:
                        Console.WriteLine("You chose Wings & Fries");
                        break;
                    case Food.GREEKSALAD:
                        Console.WriteLine("You chose Greek Salad");
                        break;
                    case Food.EXIT:
                        Console.WriteLine("Thank you for Participating");
                        break;
                    default:
                        Console.WriteLine("Error! Invalid entry!!");
                        break;

                }
                Console.WriteLine("Press any key to continue....");
                Console.ReadKey();
                Console.Clear();

            }

           

            

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();



        }
    }
}
