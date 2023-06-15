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
            Worker kris = new Worker("Кристина", "Баранова", 20, 5);
            kris.GetSalary();
        }
    }
}
