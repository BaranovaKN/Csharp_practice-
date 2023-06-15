using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ab";
            string j = "aabbccd";
            int counter = 0;
            for (int i = 0; i < j.Length; i++)
            {
                if (j[i] == s[0] || j[i] == s[1])
                {
                    counter++;
                }
            }
            Console.WriteLine($"s = {s}");
            Console.WriteLine($"j = {j}");
            Console.WriteLine(counter);
        }
    }
}
