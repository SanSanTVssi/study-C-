using System;

namespace ConsoleAppLesson2
{
    public class Converter
    {
        private double _usd;
        private double _eur;
        private double _rub;

        public Converter(double usd, double rub, double eur)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }

        public double Convert(double value, string currency1, bool ToUAH = false)
        {
            if (!ToUAH)
            {
                switch (currency1)
                {
                    case "eur": return Math.Round(value * _eur, 2);
                    case "rub": return Math.Round(value * _rub, 2);
                    case "usd": return Math.Round(value * _usd, 2);
                    default: return -1;
                }
            }
            else
            {
                switch (currency1)
                {
                    case "eur": return Math.Round(value / _eur, 2);
                    case "rub": return Math.Round(value / _rub, 2);
                    case "usd": return Math.Round(value / _usd, 2);
                    default: return -1;
                }
            }
        }
    }
}