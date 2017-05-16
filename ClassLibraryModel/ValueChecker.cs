using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements
{
    public static class ValueChecker
    {
        public static double CheckValue(double value)
        {
            if ((value >= 0) && (value != Double.NaN) && (value != Double.PositiveInfinity))
            {
                return value;
            }
            throw new ArgumentException("Элекстроемкость должна быть положительной, но не Nan и не PositiveInfinity ");
        }
    }
}
