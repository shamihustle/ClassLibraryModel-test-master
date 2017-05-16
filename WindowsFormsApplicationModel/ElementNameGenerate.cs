using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Elements.View
{
    static class ElementNameGenerate
    {
        static private int _rCount;
        static private int _cCount;
        static private int _iCount;

        static public string GenerateNameResistor()
        {
            _rCount++;
            return "R" + _rCount;
        }

        static public string GenerateNameInductor()
        {
            _iCount++;
            return "I" + _iCount;
        }

        static public string GenerateNameCapacitor()
        {
            _cCount++;
            return "C" + _cCount;
        }

    }
}
