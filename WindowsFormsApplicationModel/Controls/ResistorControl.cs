using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements.View
{
    public partial class ResistorControl : UserControl
    {
        public ResistorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация полей резизстора
        /// </summary>
        public Resistor Resistor
        {
            get
            {
                var resistor = new Resistor();
                resistor.Name = textBoxNameResistor.Text;
                try
                {
                    resistor.Value = Convert.ToDouble(textBoxResistance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error Resistance");
                    throw exception;
                }
                return resistor;
            }

            set
            {
                textBoxResistance.Text = value.Value.ToString(CultureInfo.InvariantCulture);
                textBoxNameResistor.Text = value.Name;
                try
                {
                    double textBoxResistor = Convert.ToDouble(textBoxResistance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error Resistance");
                    throw exception;
                }
            }
        }

        /// <summary>
        /// Заполнение поля имени резистора
        /// </summary>
        /// <param name="nameResistor"></param>
        public void ChangeNameResistor(string nameResistor)
        {
            textBoxNameResistor.Text = nameResistor;
        }
    }
}
