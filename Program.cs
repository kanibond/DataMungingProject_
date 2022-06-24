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
            switch (userOutput)
            {
                case "football":
                ReadDataFiles.ReadFootballFile();
                 ProcessDataFiles.ProcessFootballFile();                   
                 break;

                case "weather":
                   ReadDataFiles.ReadWeatherFile();
                    ProcessDataFiles.ProcessWeatherFile();                
                    break;

                default:
                    StandardMessage.EnterACorrectData();
                    break;
            }       
                StandardMessage.ExitApplication();                           
            
        }
    }
}
