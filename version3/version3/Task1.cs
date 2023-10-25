using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version3
{
    public class Task1
    {

        
            public void task1()
            {
                int temperature = 22;
                string city = "yerevan"; 

                for (int day = 1; day <= 7; day++)
                {
                    
                    double temperatureInFahrenheit = (temperature * 9.0 / 5.0) + 32.0;

                    Console.WriteLine($"Day {day} in {city}: Temperature is {temperatureInFahrenheit}°F");
                }
            }
        }







    }

