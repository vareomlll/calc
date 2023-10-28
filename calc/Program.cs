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
                    Console.WriteLine(n);
                break;

                case "-":
                    n = a - b;
                    Console.WriteLine(n);
                break;

                case "*":
                n = a * b;
                    Console.WriteLine(n);
                break;

                case "%":
                if (b == 0)
                    {
                        Console.WriteLine("неа");
                        break;
                    }
                    n = a % b;
                Console.WriteLine(n);
                break;
            }
            Console.ReadLine();
        }
    }
}
