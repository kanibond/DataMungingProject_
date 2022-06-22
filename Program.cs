using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace DataMunging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weather.WeatherFile();
            Football.FootballFile();
            Console.ReadLine();
        }
    }
}
