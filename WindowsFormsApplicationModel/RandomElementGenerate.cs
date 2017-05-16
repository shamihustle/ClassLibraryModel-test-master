using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elements;

namespace Elements.View
{
    static class RandomElementGenerate
    {
        /// <summary>
        /// Генерация случайного элемента
        /// </summary>
        /// <returns></returns>
        static public IElement CreateRandomElement()
        {
            Random rand = new Random();
            int n = rand.Next(0, 3);

            switch (n)
            {
                case 0:
                {
                    var r = new Resistor();
                    r.Value = rand.Next(0, 200);
                    r.Name = "R";
                    return r;
                }
                case 1:
                {
                    var c = new Capacitor();
                    c.Value = rand.Next(0, 200);
                    c.Name = "C";
                    return c;
                }
                case 2:
                {
                    var i = new Inductor();
                    i.Value = rand.Next(0, 200);
                    i.Name = "I";
                    return i;
                }
            }
            return null;
        }
    }
}
