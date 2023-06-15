using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            Train train1 = new Train();
            train1.destination = "Nsk";
            train1.departureTime = new DateTime(2023, 5, 10, 13, 50, 00);
            train1.trainNum = 1;
            Train train2 = new Train();
            train2.destination = "Spb";
            train2.departureTime = new DateTime(2023, 5, 14, 18, 15, 00);
            train2.trainNum = 2;
            Train train3 = new Train();
            train3.destination = "Msk";
            train3.departureTime = new DateTime(2023, 5, 12, 12, 00, 00);
            train3.trainNum = 3;
            Console.Write("выберите номер поезда(1-3): ");
            int usernum = Convert.ToInt32(Console.ReadLine());
            switch (usernum)
            {
                case 1:
                    Train.PrintInfoTrain(train1.destination, train1.departureTime, train1.trainNum);
                    break;
                case 2:
                    Train.PrintInfoTrain(train2.destination, train2.departureTime, train2.trainNum);
                    break;
                case 3:
                    Train.PrintInfoTrain(train3.destination, train3.departureTime, train3.trainNum);
                    break;
            }
        }
    }
}
