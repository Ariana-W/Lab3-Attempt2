using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean run = true;
            while (run)
            {
                string something = " ";

                Console.WriteLine("Please enter in an integer");
                ulong userInput = ulong.Parse(Console.ReadLine());

                Console.WriteLine("    Numbers        Square        Cube ");
                Console.WriteLine("  ===========    ===========  ==========");

                for (ulong i = 1; i <= userInput; i++)
                {
                    something += i;

                    // Console.WriteLine(i);

                    ulong num = i * i;
                    something += string.Format("{0,20}", num);


                    ulong numm = i * i * i;
                    something += string.Format("{0,14}", numm);

                    something += "\n";
                }

                Console.WriteLine(something);
                Continue();
            }
        }

        public static Boolean Continue()

        {
            bool run = true;

            Console.WriteLine("Would you like to continue? Yes or No? ");
            string userInput = Console.ReadLine().ToLower().Trim();

            if (userInput == "yes" || userInput == "y")
            {
                run = true;
            }
            if (userInput == "no" || userInput == "n")
            {
                run = false;
                Console.WriteLine("Thanks for chilling with us!");
            }

            if (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("You entered in a wrong value. Please try again");
                run = Continue();
            }

            return run;
        }

    }

}

