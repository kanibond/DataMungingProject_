using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMunging
{
    public class ReadDataFiles
    {
        public static DataTable ReadWeatherFile()
        {            
            var weatherTable = new DataTable();
            weatherTable.Columns.Add("Dy");
            weatherTable.Columns.Add("MxT");
            weatherTable.Columns.Add("MnT");
            weatherTable.Columns.Add("AvT");
            weatherTable.Columns.Add("HDDay");
            weatherTable.Columns.Add("AvDP");
            weatherTable.Columns.Add("1HrP");
            weatherTable.Columns.Add("TPcpn");
            weatherTable.Columns.Add("WxType");
            weatherTable.Columns.Add("PDir");
            weatherTable.Columns.Add("AvSp");
            weatherTable.Columns.Add("Dir");
            weatherTable.Columns.Add("MxS");
            weatherTable.Columns.Add("SkyC");
            weatherTable.Columns.Add("MxR");
            weatherTable.Columns.Add("MnR");
            weatherTable.Columns.Add("AvSLP");

          return weatherTable;

        }

        public static DataTable ReadFootballFile()
        {            
            var footballTable = new DataTable();
            footballTable.Columns.Add("");
            footballTable.Columns.Add("Team");
            footballTable.Columns.Add("P");
            footballTable.Columns.Add("W");
            footballTable.Columns.Add("L");
            footballTable.Columns.Add("D");
            footballTable.Columns.Add("F");
            footballTable.Columns.Add("");
            footballTable.Columns.Add("A");
            footballTable.Columns.Add("Pts");
            footballTable.Columns.Add("Diff");

              return footballTable;
        }
    }
}