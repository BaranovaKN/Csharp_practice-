﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class WeatherResponse
    {
        public TemperatureInfo Main { get; set; }
        public string Name { get; set; }
        public WeatherInfo[] Weather { get; set; }
        public WindInfo Wind { get; set; }
    }
}
