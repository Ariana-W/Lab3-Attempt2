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
            string format = " ";

            Console.WriteLine("Please enter in an integer");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("    Numbers        Square        Cube ");
            Console.WriteLine("  ===========    ===========  ==========");

          

            for (int i = 1; i <= userInput; i++)
            {
                
                Console.WriteLine(i);
            
                int num = i * i;
                string num1 = string.Format("{0,20}", num);
                Console.WriteLine(num1);

                int numm = i * i * i;
                string num2 = string.Format("{0,25}", numm);

                Console.WriteLine(num2);

                format = "\n";
            }
        
            Console.WriteLine(format);

            format += "0-------------------5-------------10-----------15" + "\n";
        }

        //public static void Square(int userInput)
        //{
        //   int num = userInput * userInput;
        //   string num1 = string.Format("{0,20 }", num);
        //   Console.WriteLine(num1);        
        //}

        //public static void Cube(int userInput)
        //{
        //    int num = userInput * userInput * userInput;
        //    string num1 = string.Format("{0,36 }", num);
        //    Console.WriteLine(num1);
        //}

    }

}

