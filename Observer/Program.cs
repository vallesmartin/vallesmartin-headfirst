using System;

namespace vallesmartin.HeadFirst.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The Observer Pattern defines a one-to-many 
                dependency between objects so that when one 
                object changes state, all of its dependents are 
                notified and updated automatically.
            */
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
