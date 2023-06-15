using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Train
    {
        public string destination { get; set; }
        public DateTime departureTime { get; set; }
        public int trainNum { get; set; }
        public static void PrintInfoTrain(string destination, DateTime departureTime , int trainNum)
        {
            Console.WriteLine($"Информация о поезде \n Пункт назначения: {destination} \n Номер поезда: {trainNum} \n Время отправления: {departureTime}");
        }
    }
}
