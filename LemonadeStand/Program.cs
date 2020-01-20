using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Day day1 = new Day();




            Console.WriteLine(day1.weather.dailyTemperature + day1.weather.dailyCondition);
            Console.ReadLine();
        }
    }
}
