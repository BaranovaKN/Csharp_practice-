using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Worker
    {
        private string Name, Surname;
        private int Days, Rate;
        public void Set(string Name, string Surname, int Days, int Rate)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Days = Days;
            this.Rate = Rate;
        }
        public void Get()
        {
            Console.WriteLine($"Фамилия имя сотрудника: {Name} {Surname} \n Зарабтная плата  со ставкой {Rate} в день, за {Days} дней: {Days * Rate}");
        }
    }
}
