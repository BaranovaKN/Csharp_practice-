using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            Worker kris = new Worker();
            kris.Set("Кристина", "Баранова", 20, 5);
            kris.Get();
        }
    }
}
