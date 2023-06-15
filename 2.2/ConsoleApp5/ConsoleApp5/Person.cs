using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApp5
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person(string name) => Name = name;
        public Person(int Age) => Age = 0;
        public Person()
        {
            Name = "Tom";
            Age = 21;
        }
        ~Person()
        {
            Console.WriteLine($"{Name} and {Age} has been deleted");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {Name} \nВозрас: {Age}");
        }
        public void DeafultPerson()
        {
            Name = "Отсутствует";
            Age = 0;
        }
    }
}
