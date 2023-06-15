using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Num usernum = new Num();
            usernum.numfirst = 1;
            usernum.numsecond = 2;
            bool counter = true;
            usernum.PrintNum();
            while (counter)
            {
                Console.Write($"Выберете действие\n Вывести числа(1), Сменить числа(2), найти большее число(3), закончить(4) - ");
                int userchoice = Convert.ToInt32(Console.ReadLine());
                switch (userchoice)
                {
                    case 1:
                        usernum.PrintNum();
                        break;
                    case 2:
                        Console.Write("Выберете число которое хотите изменить - ");
                        int userchoicenum = Convert.ToInt32(Console.ReadLine());
                        switch (userchoicenum)
                        {
                            case 1:
                                Console.Write("Введите новое первое число: ");
                                usernum.numfirst = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 2:
                                Console.Write("Введите новое первое число: ");
                                usernum.numsecond = Convert.ToInt32(Console.ReadLine());
                                break;
                        }
                        break;
                    case 3:
                        usernum.СompareNum();
                        break;
                    case 4:
                        counter = false;
                        break;

                }

            }
        }
    }
}
