using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            Storage userCounter = new Storage();
            userCounter.counter = 0;
            bool work = true;
            while (work)
            {
                Console.WriteLine("Выберете действие счетчика\n Вывести значение(1), задать значение(2), увеличить число на 1(3), уменьшить на 1(4), закончить работу(5)");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:
                        userCounter.PrintInfo();
                        break;
                    case 2:
                        Console.Write("Введите новое значение: ");
                        userCounter.counter = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        userCounter.PlusOne();
                        break;
                    case 4:
                        userCounter.MinusOne();
                        break;
                    case 5:
                        work = false;
                        break;
                }
            }
        }
    }
}
