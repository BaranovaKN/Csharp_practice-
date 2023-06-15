using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            Student Baranova = new Student();
            Baranova.name = "Баранова К.Н.";
            Baranova.dob = new DateTime(2003, 10, 5);
            Baranova.groupNumber = 623;
            Baranova.grades = new[] { 5, 5, 5, 5, 5 };
            Console.Write("Выберете: коректировать данные(1) или вывести информацию(2): ");
            int userСhoice = Convert.ToInt32(Console.ReadLine());
            switch (userСhoice)
            {
                case 1:
                    bool workingWithData = true;
                    Student.PrintInfo(Baranova.name, Baranova.dob, Baranova.groupNumber, Baranova.grades);    
                    while (workingWithData)
                    {
                        Console.Write("\n Выберете какие данные хотите изменить: Фио(1), дату рождения(2), номер группы(3), вывести информацию(4): ");
                        int userСhoice2 = Convert.ToInt32(Console.ReadLine());
                        switch (userСhoice2)
                        {
                            case 1:
                                Console.Write("Введите новое ФИО: ");
                                Baranova.name = Console.ReadLine();
                                break;
                            case 2:
                                Console.Write("Введите новую дату рождения: ");
                                Baranova.dob = Convert.ToDateTime(Console.ReadLine());
                                break;
                            case 3:
                                Console.Write("Введите новую группу: ");
                                Baranova.groupNumber = Convert.ToInt32(Console.ReadLine());
                                break;
                            case 4:
                                Student.PrintInfo(Baranova.name, Baranova.dob, Baranova.groupNumber, Baranova.grades);
                                workingWithData = false;
                                break;
                        }
                    }
                    break;
                case 2:
                    Student.PrintInfo(Baranova.name, Baranova.dob, Baranova.groupNumber, Baranova.grades);
                    break;
                    
            }
        }
    }
}
