using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Elements;
using System.Numerics;

namespace UnitTests.Elements
{
    [TestFixture]
    class ResistorTest
    {
        [Test, TestCaseSource(nameof(ComplexValueTest))]
        public void GetImpedanceTest(double resultReal, double resulrImaginary, double angularFrequency, double value)
        {
            var resistor = new Resistor(value);
            var impedance = resistor.GetImpedance(angularFrequency);

            Assert.AreEqual(resultReal, impedance.Real);
            Assert.AreEqual(resulrImaginary, impedance.Imaginary);
        }

        static readonly TestCaseData[] ComplexValueTest =
        {
        new TestCaseData(12.0, 0, 12, 12),
        new TestCaseData(45.7, 0 , 23.5, 45.7),
        new TestCaseData(1, 0, 1, 1)
        };

    }
}
