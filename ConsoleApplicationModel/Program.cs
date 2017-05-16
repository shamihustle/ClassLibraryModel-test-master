using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryModel;
using System.Numerics;

namespace ConsoleApplicationModel
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            var ElementList = new List<IElement>();

            while (f != true)
            {

                try
                {
                    var r1 = new Resistor(Convert.ToDouble(Console.ReadLine()));
                    var i1 = new Inductor(Convert.ToDouble(Console.ReadLine()));
                    var c1 = new Capacitor(Convert.ToDouble(Console.ReadLine()));
                    ElementList.Add(r1);
                    ElementList.Add(i1);
                    ElementList.Add(c1);
                    f = true;
                }
                
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }
            

            Complex sum;
           
            sum =  ElementList[0].GetImpedance(2e9 * 2 * Math.PI) + ElementList[1].GetImpedance(2e9*2*Math.PI);
             
            Console.WriteLine("\n" + ElementList[0].GetImpedance(3e9 * 2 * Math.PI) + " + " + ElementList[1].GetImpedance(3e9 * 2 * Math.PI) + " = " + sum); 

            Console.ReadKey();
        }
    }
}
