using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Elements
{

    /// <summary>
    /// Элемент
    /// </summary>
    
    public interface IElement
    {
        double Value { get; set; }
        string Name { get; set; }

        /// <summary>
        /// Комплексное сопротивление
        /// </summary>
        /// <param name="angularFrequency">Угловая частота</param>
        /// <returns> Комплексное сопротивление </returns>
        Complex GetImpedance(double angularFrequency);

    }
}