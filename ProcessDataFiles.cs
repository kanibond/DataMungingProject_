using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class ProcessDataFiles 
    {           
        public static DataTable ProcessWeatherFile()
        {
            string outputWeather = Directory.GetCurrentDirectory() + "\\weather.txt";
            var lines = File.ReadAllLines(outputWeather);
            var _weatherTable = ReadDataFiles.ReadWeatherFile();


            foreach (var line in lines.Skip(2))
            {
                var firstValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                _weatherTable.Rows.Add(firstValue);
            }

            _weatherTable.DefaultView.Sort = "MnT ASC";
            _weatherTable = _weatherTable.DefaultView.ToTable();
            Console.WriteLine("");

            Console.WriteLine("------- Weather Data -------");
            Console.WriteLine();
            Console.WriteLine("Day: " + _weatherTable.Rows[0]["Dy"]);
            Console.WriteLine("Smallest temperature spread: " + _weatherTable.Rows[0]["MnT"]);

            return _weatherTable;
        }


        public static DataTable ProcessFootballFile()
        {
            string outputFootball = Directory.GetCurrentDirectory() + "\\Football.txt";
            var lines = File.ReadAllLines(outputFootball);
            var _footballTable = ReadDataFiles.ReadFootballFile();

            foreach (var line in lines)
            {
                var firstValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var diff = int.Parse(firstValue[6].ToString()) - int.Parse(firstValue[8].ToString());
                firstValue = firstValue.Append(diff.ToString()).ToArray();
                _footballTable.Rows.Add(firstValue);
            }


            var differences = _footballTable.AsEnumerable()
            .Select(al => new
            {
                Diff = Convert.ToInt32(al.Field<string>("Diff")),
                TeamName = al.Field<string>("Team")
            }).ToList();
            var min = differences.OrderBy(x => x.Diff).FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("------- Football -------");
            Console.WriteLine("Team with smallest difference: " + min.TeamName.ToString());

            return _footballTable;
        }
    }


    
}
