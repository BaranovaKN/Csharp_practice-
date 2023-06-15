using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Calculation
    {
		private string CalculationLine;
        public void SetCalculationLine()
        {
            Console.Write("Введите строку: ");
            string userLine = Console.ReadLine();
            this.CalculationLine = userLine;
        }
        public void SetLastSymbolCalculationLine()
        {
            Console.Write("Ввдеите символ: ");
            char userSymbol = Convert.ToChar(Console.ReadLine());
            this.CalculationLine += userSymbol;
        }
        public void GetCalculationLine()
        {
            Console.WriteLine(CalculationLine);
        }
        public void GetLastSymbol()
        {
            Console.WriteLine(CalculationLine[CalculationLine.Length-1]); 
        }
        public void DeleteLastSymbol()
        {
            CalculationLine = CalculationLine.Remove(CalculationLine.Length - 1);
        }
    }
}
