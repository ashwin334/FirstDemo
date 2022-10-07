using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = 2022;
            string month = "Sept";
            int day = 29;
            
            // interpolation --> $ sign

            Console.WriteLine($"/n Day is {day} Current year is {year} /t & month is {month}");

        }
    }
}
