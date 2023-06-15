using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            Calculation user = new Calculation();
            user.SetCalculationLine();
            bool a = true;
            while (a)
            {
                Console.Write("Выберите изменить значение строки(0), добавить в конце строки символ(1), вывести строку(2), вывести последний символ(3), удалить последний символ(4), закончить(5): ");
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 0:
                        user.SetCalculationLine();
                        break;
                    case 1:
                        user.SetLastSymbolCalculationLine();
                        break;
                    case 2:
                        user.GetCalculationLine();
                        break;
                    case 3:
                        user.GetLastSymbol();
                        break;
                    case 4:
                        user.DeleteLastSymbol();
                        break;
                    case 5:
                        a = false;
                        break;
                }
            }
        }
    }
}
