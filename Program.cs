using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число х= ");
            int x = Convert.ToInt32(Console.ReadLine());
             Console.Write("Введите целое число y= ");
            int y = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("Введите код операции: ");
           Console.WriteLine("1-сложение "); 
           Console.WriteLine("2-вычитание ");
           Console.WriteLine("3-произведение ");
           Console.WriteLine("4-частное ");
            int n = Convert.ToByte(Console.ReadLine());
           

            switch (n)
            {
                case 1:
                    {
                       Console.WriteLine("Ваш выбор 1: ");
                       Console.WriteLine(x + y);
                    }
                    
            
                    break;
                    case 2:
                    { 
                        Console.WriteLine("Ваш выбор 2: ");
                        Console.WriteLine(x - y);

                    }
                    
                    break;
                    case 3:
                    {
                        Console.WriteLine("Ваш выбор 3: ");
                        Console.WriteLine(x * y);

                    }
                    break;
                    case 4:
                    {
                        Console.WriteLine("Ваш выбор 4: ");
                        Console.WriteLine(x / y);

                    }


                    break;

                    default:
                    Console.WriteLine("Вы ввели неверное значение");
                    break;

            }




            Console.ReadKey();
        }
}
    }
           
