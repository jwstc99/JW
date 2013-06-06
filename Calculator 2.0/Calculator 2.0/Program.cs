using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            int op;
            string line = Environment.NewLine;
            
            do
            {
                Console.WriteLine("Select an operator");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("Press 5 to quit");

                
            op = Convert.ToInt32(Console.ReadLine());
            
            if (op != 5)
            {
                Console.WriteLine("Enter a number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number:");
            num2 = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2)+line+line);
                        break;
                    case 2:
                        Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2)+line+line);
                        break;
                    case 3:
                        Console.WriteLine(num1 + " X " + num2 + " = " + (num1 * num2)+line+line);
                        break;
                    case 4:
                        Console.WriteLine(num1 + " / " + num2 + " = " + (num1 / num2)+line+line);
                        break;




                }
            }

            } while (op != 5);
            
            
            Console.WriteLine("Press Enter To Exit...");
            Console.Read();
        }
    }
}
