﻿namespace vallesmartin.HeadFirst.Observer
{
    public interface IObserver
    {
        void update(float temp, float humidity, float pressure);
    }
}
