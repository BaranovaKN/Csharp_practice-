using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            bool cycle = true;
            List<string> cityList = new List<string>();
            while (cycle)
            {
                
                Console.Write("Посмотреть погоду в городе(0), посмотреть список просмотренных городов(1), закончить(2): ");
                int userChoise = Convert.ToInt32(Console.ReadLine());
                switch (userChoise)
                {
                    case 0:
                        Console.Write("Выберете город: ");
                        string city = Console.ReadLine();
                        cityList.Add(city);
                        string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid=4c9b24813ab03f641d169f9d7a0fd127&units=metric";
                        HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                        HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        string response;
                        using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
                        {
                            response = streamReader.ReadToEnd();
                        }
                        WeatherResponse weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(response);
                        Console.WriteLine($"Погода в городе {weatherResponse.Name}: {weatherResponse.Main.Temp}°C \n" +
                            $"Ощущается как: {weatherResponse.Main.Feels_Like}°C \n" +
                            $"Максимальная температура в пределах города: {weatherResponse.Main.Temp_Max}°C \n" +
                            $"Минимальная температура в пределах города: {weatherResponse.Main.Temp_Mine}°C \n" +
                            $"Погодные условия: {weatherResponse.Weather[0].Main}\n" +
                            $"Дополнительные сведения о погодных условиях: {weatherResponse.Weather[0].Description} \n" +
                            $"Скорость ветра: {weatherResponse.Wind.Speed} м/с");
                        break;
                    case 1:
                        for (int i = 0; i < cityList.Count; i++)
                        {
                            Console.WriteLine(cityList[i]);
                        }
                        break;
                    case 2:
                        cycle = false;
                        break;
                }  
            }
        }
    }
}
