using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{

    class Storage
    {
        public int counter { get; set; }

        public void PrintInfo()
        {
            Console.WriteLine(counter);
        }
        public void PlusOne()
        {
            counter++;
        }
        public void MinusOne()
        {
            counter--;
        }
    }
}
