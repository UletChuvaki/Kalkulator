using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double b;
            

            Console.WriteLine("Введите число1");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите символ");
            string i = Console.ReadLine();
            switch (i)
            {
                case "+":
                    break;

                case "-":
                    break;

                case "*":
                    break;


                case "/":
                    break;

                default:
                    Console.WriteLine("Вы ввели неизвестный символ");
                    break;

            }

            Console.WriteLine("Введите число");
            b = double.Parse(Console.ReadLine());

            double res4 = a + b;
            double res1 = a - b;
            double res2 = a * b;
            double res3 = a / b;

            Console.WriteLine("Ответ" + res4 , res1 , res2, res3 ) ;


            
             


        }
    }
}
