using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class Football
    {
        public static void FootballFile()
        {
            var filePath = Directory.GetCurrentDirectory() + "\\Football.txt";
            var lines = File.ReadAllLines(filePath);

            DataTable table = new DataTable();
            table.Columns.Add("");
            table.Columns.Add("Team");
            table.Columns.Add("P");
            table.Columns.Add("W");
            table.Columns.Add("L");
            table.Columns.Add("D");
            table.Columns.Add("F");
            table.Columns.Add("");
            table.Columns.Add("A");
            table.Columns.Add("Pts");
            table.Columns.Add("Diff");

            foreach (var line in lines)
            {
                var firstValue = line.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var diff = int.Parse(firstValue[6].ToString()) - int.Parse(firstValue[8].ToString());
                firstValue = firstValue.Append(diff.ToString()).ToArray();
                table.Rows.Add(firstValue);
            }

            var differences = table.AsEnumerable()
            .Select(al => new
            {
                Diff = Convert.ToInt32(al.Field<string>("Diff")),
                TeamName = al.Field<string>("Team")
            }).ToList();
            var min = differences.OrderBy(x => x.Diff).FirstOrDefault();

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("------- Football -------");
            Console.WriteLine("");
            Console.WriteLine("Team with smallest difference: " + min.TeamName.ToString());
            Console.ReadLine();
        }
    }
}
