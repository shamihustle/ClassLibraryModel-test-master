using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Numerics;
using Elements;

namespace UnitTests.Elements
{
    /// <summary>
    /// Тестирование класса Inductor
    /// </summary>
    [TestFixture]
    class InductorTest
    {
        [Test, TestCaseSource(nameof(ComplexValueTest))]
        public void GetImpedanceTest(double resultReal, double resulrImaginary, double angularFrequency, double value)
        {
            var inductor = new Inductor(value);
            var impedance = inductor.GetImpedance(angularFrequency);

            Assert.AreEqual(resultReal, impedance.Real);
            Assert.AreEqual(resulrImaginary, impedance.Imaginary);
        }

        static readonly TestCaseData[] ComplexValueTest =
        {
        new TestCaseData(0, -144.0 , 12, 12),
        new TestCaseData(0, -1073.95 , 23.5, 45.7),
        new TestCaseData(0, -1, 1, 1)
        };
    }
}
