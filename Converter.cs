using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyConverter
{
    class Converter
    {
        private double usd_rate;
        private double euro_rate;
        public Converter(double usd = 0.035 ,double euro = 0.030) //конструктор.(стандартні параметри обрав як курс валют станом на 28 вересня)
        {
            usd_rate = usd;
            euro_rate = euro;
        }
        //методи для повернення курсу валют
        public double GetUsd()
        {
            return usd_rate;
        }
        public double GetEuro()
        {
            return euro_rate;
        }
    }
}
