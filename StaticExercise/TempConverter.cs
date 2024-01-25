using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempFahren) 
        {
            return (tempFahren - 32) * 5 / 9;
        }

        public static double CelsiusToFahrenheit(double tempCelsius) 
        {
            return (tempCelsius * 9) / 5 + 32;
        }

    }
}
