using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string name { get; set; }
        public DateTime dob { get; set; }
        public int groupNumber { get; set; }
        public int[] grades { get; set; } = new int[5];

        public static void PrintInfo(string name, DateTime dob, int groupNumber, int[] grades)
        {
            Console.Write($"Информация о студенте:\n ФИО: {name} \n Дата рождения: {dob.ToString("d")} \n Группа:{groupNumber} \n Успеваемость:");
            foreach (int i in grades)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
