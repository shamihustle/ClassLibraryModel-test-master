using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Elements
{
    /// <summary>
    /// Индуктор
    /// </summary>
    [Serializable]
    public class Inductor : IElement
    {
        /// <summary>
        /// Индукция
        /// </summary>
        private double _value;

        /// <summary>
        /// Индукция
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }

        public Complex GetImpedance(double angularFrequency)
        {
            return new Complex(0, -angularFrequency*_value);
        }


        public Inductor()
        {

        }

        /// <summary>
        /// Конструктор с параметром Индуктор
        /// </summary>
        /// <param name="Индуктивность"></param>
        public Inductor(double value)
        {
            _value = ValueChecker.CheckValue(value);
        }


        public string Name { get; set;}
    }
}