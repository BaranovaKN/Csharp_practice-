using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Rate { get; set; }
        public int Days { get; set; }
        public Worker(string Name, string Surname, int Rate, int Days) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Rate = Rate;
            this.Days = Days;
        }
        public void GetSalary()
        {
            Console.WriteLine($"Фамилия имя сотрудника: {Name} {Surname} \n Зарабтная плата  со ставкой {Rate} в день, за {Days} дней: {Days  * Rate}");
        }
    }
}
