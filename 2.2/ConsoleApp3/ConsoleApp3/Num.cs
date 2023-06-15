using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Num
    {
        public int numfirst { get; set; }
        public int numsecond { get; set; }
        public void PrintNum()
        {
            Console.WriteLine($"Число 1 - {numfirst} \n Число 2 - {numsecond} ");
        }
        public void СompareNum()
        {
            if (numfirst > numsecond)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Второе число больше первого");
            }
        }
    }
}
 