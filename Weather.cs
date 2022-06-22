using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class Weather
    {
        public static void WeatherFile()
        {
            var filePath = Directory.GetCurrentDirectory() + "\\weather.txt";
            var lines = File.ReadAllLines(filePath);

            DataTable table = new DataTable();
            table.Columns.Add("Dy");
            table.Columns.Add("MxT");
            table.Columns.Add("MnT");
            table.Columns.Add("AvT");
            table.Columns.Add("HDDay");
            table.Columns.Add("AvDP");
            table.Columns.Add("1HrP");
            table.Columns.Add("TPcpn");
            table.Columns.Add("WxType");
            table.Columns.Add("PDir");
            table.Columns.Add("AvSp");
            table.Columns.Add("Dir");
            table.Columns.Add("MxS");
            table.Columns.Add("SkyC");
            table.Columns.Add("MxR");
            table.Columns.Add("MnR");
            table.Columns.Add("AvSLP");

            foreach (var line in lines.Skip(2))
            {
                var firstValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                table.Rows.Add(firstValue);
            }

            table.DefaultView.Sort = "MnT ASC";
            table = table.DefaultView.ToTable();
            Console.WriteLine();
            Console.WriteLine("------- Weather Data -------");
            Console.WriteLine();
            Console.WriteLine("Day: " + table.Rows[0]["Dy"]);
            Console.WriteLine("Smallest temperature spread: " + table.Rows[0]["MnT"]);

        }
    }
}
