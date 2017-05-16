using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements.View.Controls
{
    public partial class ElementControl : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public ElementControl()
        {
            InitializeComponent();

            comboBoxElements.Items.Add("Resistor");
            comboBoxElements.Items.Add("Inductor");
            comboBoxElements.Items.Add("Capacitor");

            resistorControl.Visible = false;
            inductorControl.Visible = false;
            capacitorControl.Visible = false;
        }

        /// <summary>
        /// Инициализация элемента
        /// </summary>
        public IElement Elements
        {
            get
            {
                IElement element = null;
                int ss = comboBoxElements.SelectedIndex;

                switch (ss)
                {
                    case 0:
                    {
                        try
                        {
                            element = resistorControl.Resistor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 1:
                    {
                        try
                        {
                            element = inductorControl.Inductor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                    case 2:
                    {
                        try
                        {
                            element = capacitorControl.Capacitor;
                        }
                        catch (FormatException exception)
                        {
                            throw exception;
                        }
                        break;
                    }
                }
                return element;
            }
            set
            {
                if (value is Resistor)
                {
                    comboBoxElements.SelectedIndex = 0;
                    try
                    {
                        resistorControl.Resistor = (Resistor)value;
                    }
                    catch (FormatException exception)
                    {
                        throw exception;
                    }

                }
                if (value is Inductor)
                {
                    comboBoxElements.SelectedIndex = 1;

                    inductorControl.Inductor = (Inductor) value;

                }
                if (value is Capacitor)
                {
                    comboBoxElements.SelectedIndex = 2;

                    capacitorControl.Capacitor = (Capacitor)value;
                }
            }
        }

        /// <summary>
        /// Определение видимости в ComboBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            resistorControl.Visible = (comboBoxElements.SelectedIndex == 0);
            inductorControl.Visible = (comboBoxElements.SelectedIndex == 1);
            capacitorControl.Visible = (comboBoxElements.SelectedIndex == 2);
            switch (comboBoxElements.SelectedIndex)
            {
                case 0:
                {
                    resistorControl.ChangeNameResistor(ElementNameGenerate.GenerateNameResistor());
                    break;
                }
                case 1:
                {
                    inductorControl.ChangeNameInductor(ElementNameGenerate.GenerateNameInductor());
                    break;
                }
                case 2:
                {
                    capacitorControl.ChangeNameCapacitor(ElementNameGenerate.GenerateNameCapacitor());
                    break;
                }
            }
        }
    }
}
