using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {

        
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {





                Console.WriteLine("Enter a integer: ");

                //input

                string input = Console.ReadLine();
                int inputNum = Convert.ToInt32(input);

                Console.WriteLine("-----------------------");
                Console.WriteLine("");
                Console.WriteLine("number   square    cubed");

                for (int i = 1; i < (inputNum + 1); i++)
                {
                    double p2 = Math.Pow(i, 2);
                    double p3 = Math.Pow(i, 3);
                    string space = "           ";
                    Console.WriteLine("{0,0}{1,10}{2,11}",i,p2,p3);
                    //Console.WriteLine(i + space + p2 + space + p3);
                    
                }

                Console.WriteLine("type 'quit' to quit or press any key to continue");
                string quit = Console.ReadLine();
                if (quit.ToLower() == "quit")
                {
                    run = false;
                }

            }
        
        }
    }
}
