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
            var userOutput = StandardMessage.WelcomeMesage();
            userOutput = "weather";
            switch (userOutput)
            {
                case "football":
                ReadDataFiles.ReadFootballFile();
                 ProcessDataFiles.ProcessFootballFile();                   
                 break;

                default:
                   ReadDataFiles.ReadWeatherFile();
                    ProcessDataFiles.ProcessWeatherFile();                
                    break;
            }
            
                StandardMessage.ExitApplication();                           
            
        }
    }
}
