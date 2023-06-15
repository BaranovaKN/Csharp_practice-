using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Person tom = new Person();
            bool work = true;
            while (work) {
                Console.Write("Выберете действие: Изменить информацию(0), вывести информацию(1), установить значение по умолчанию(2), закончить(3): ");
                int userСhoice = Convert.ToInt32(Console.ReadLine());
            switch (userСhoice)
            {
                case 0:
                        Console.Write("Введите новое имя: ");
                        tom.Name = Console.ReadLine();
                        Console.Write("Введите новый возраст:");
                        tom.Age = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1:
                        tom.PrintInfo();
                        break;
                case 2:
                        tom.DeafultPerson();
                        Console.WriteLine("Значения изменены на значения по умолчанию");
                        break;
                case 3:
                        work = false;
                        break;
            }
            }
        } 
    }
}



