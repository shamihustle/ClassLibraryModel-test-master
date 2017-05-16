using System;
using System.Numerics;

namespace Elements
{
    /// <summary>
    /// Конденсатор 
    /// </summary>
    [Serializable]
    public class Capacitor : IElement
    {
        /// <summary>
        /// Электроёмкость
        /// </summary>
        private double _value;

        /// <summary>
        /// Электроемкость
        /// </summary>
        public double Value
        {
            get { return _value; }
            set
            {
                _value = ValueChecker.CheckValue(value);
            }
        }

        public Complex GetImpedance(double AngularFrequency)
        {
            return new Complex(0, 1/(AngularFrequency*_value));
        }


        public Capacitor()
        {

        }

        /// <summary>
        /// Конструктор с параметром Кондексатор
        /// </summary>
        /// <param name="value"></param>
        public Capacitor(double value)
        {
            _value = ValueChecker.CheckValue(value);
        }

        public string Name { get; set; }
    }
}
