namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Fahrentheit -> Celsius: {TempConverter.FahrenheitToCelsius(32)} ");
            TempConverter.FahrenheitToCelsius(32);

            Console.Write($"Celsius -> Fahrentheit: {TempConverter.CelsiusToFahrenheit(0)} ");
            Console.WriteLine();


        }
    }
}
