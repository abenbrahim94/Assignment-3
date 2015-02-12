using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmnent_3.Ahmed_Benbrahim
{
    class Program
    {
        static void Main(string[] args)
        {
            int MenuChoices;
            string Menu;
            bool answer;

            Console.WriteLine("====================MENU====================");
            Console.WriteLine("From the Menu below, Choose what you would like to eat ");
            Console.WriteLine("Please Enter your Choice: ");
            Console.WriteLine("====================================");
            Console.WriteLine("1 - Burger & Fries ");
            Console.WriteLine("2 - Pizza ");
            Console.WriteLine("3 - Garden Salad ");
            Console.WriteLine("4 - Wings & Fries ");
            Console.WriteLine("5 -  Greek Salad");
            Console.WriteLine("6 - Falafel ");
            Console.WriteLine("7 - Spaghetti & Meatballs ");
            Console.WriteLine("8 - Fried Chicken & Fries ");
            Console.WriteLine("9 - Rice & Curry ");
            Console.WriteLine("10 - Shawarma ");
            Console.WriteLine("Press 11 to Exit ");


            Console.WriteLine("Please make your selection (1 to 10) And 11 to Exit");

            Console.WriteLine("Please Enter your Choice: ");
    
            Menu = Console.ReadLine();
            Console.Write("\n");
            MenuChoices = Convert.ToInt32(Menu);


            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("press any key to exit");
            Console.ReadKey();



        }
    }
}
