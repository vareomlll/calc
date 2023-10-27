using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double n = 0;

            string c = Console.ReadLine();

            switch (c)
            {
                //я второй раз работаю в VS после PyCharm и я уже обожаю VS он же просто дописывает код за мной
                case "+":
                    n = a + b; 
                break;

                case "-":
                    n = a - b;
                break;

                case "*":
                n = a * b;
                break;

                case "/":
                n = a / b;
                break;

                case "%":   
                n = a % b;
                break;
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
