using System;

namespace vallesmartin.HeadFirst.Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplay
    {
        private float _temp, _humidity, _pressure;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Current conditions: " + _temp.ToString() + "C degrees. " + _humidity.ToString() + " %. " + _pressure.ToString() + " ats.");
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
