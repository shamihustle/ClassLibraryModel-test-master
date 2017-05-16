using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Elements
{
    /// <summary>
    /// Резистор
    /// </summary>
    [Serializable]
    public class Resistor : IElement
    {
        /// <summary>
        /// Сопротивление
        /// </summary>
        private double _value;

        /// <summary>
        /// Сопротивление
        /// </summary>
        public double Value
        {
            get { return _value; }
            set { _value = ValueChecker.CheckValue(value); }
        }
        

        public Complex GetImpedance(double AngularFrequency)
        {
            return new Complex(_value, 0);
        }

        public Resistor()
        {

        }
        /// <summary>
        /// Конуструктор с параметром Резистор
        /// </summary>
        /// <param name="Сопротивление"></param>
        public Resistor(double value)
        {
            _value = ValueChecker.CheckValue(value);

        }

        public string Name { get; set; }
    }
}
