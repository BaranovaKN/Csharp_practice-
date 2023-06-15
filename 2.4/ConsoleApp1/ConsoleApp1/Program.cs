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
            Console.Write("Введите число римскими цифрами: ");
            string userRomanNums = Console.ReadLine();
            int res = 0;
            Dictionary<char, int> romanNums = new Dictionary<char, int>()
        {
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };

            for (int i = 0; i < userRomanNums.Length; i++)
            {
                if (i + 1 < userRomanNums.Length && romanNums[userRomanNums[i]] < romanNums[userRomanNums[i + 1]])
                {
                    res -= romanNums[userRomanNums[i]];
                }
                else
                {
                    res += romanNums[userRomanNums[i]];
                }
            }
            Console.WriteLine("Число арабскими цифрами: " + res);
        }
    }
}
