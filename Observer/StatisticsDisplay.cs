using System;

namespace vallesmartin.HeadFirst.Observer
{
    public class StatisticsDisplay : IObserver, IDisplay
    {
        private float _temp, _humidity, _pressure;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Statistic conditions: " + _temp.ToString() + "C degrees. " + _humidity.ToString() + " %. " + _pressure.ToString() + " ats.");
        }

        public void update(float temp, float humidity, float pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            display();
        }
    }
}