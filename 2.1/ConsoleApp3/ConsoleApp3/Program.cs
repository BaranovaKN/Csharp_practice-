using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
            bool counter = false;
            for (int i = 0; i < nums.Length; i++) 
            {
                for (int j = 1;j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    { 
                        counter = true; 
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
