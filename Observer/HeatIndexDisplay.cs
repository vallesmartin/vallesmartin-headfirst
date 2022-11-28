using System;

namespace vallesmartin.HeadFirst.Observer
{
    public class HeatIndexDisplay : IObserver, IDisplay
    {
        private float _heatIndex, _temp, _humidity, _pressure;
        private WeatherData _weatherData;

        public float HeatIndex {
            get
            {
                return getHeatIndex();
            }
        }

        private float getHeatIndex()
        {
            return _temp * _humidity;
        }

        public HeatIndexDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            weatherData.registerObserver(this);
        }
        public void display()
        {
            Console.WriteLine("Heat Index conditions: " + HeatIndex.ToString() + ".");
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
