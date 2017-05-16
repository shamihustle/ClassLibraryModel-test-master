using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elements.View
{
    public partial class InductorControl : UserControl
    {
        /// <summary>
        /// Конструктор
        /// </summary>
        public InductorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация полей индуктивного элемента
        /// </summary>
        public Inductor Inductor
        {
            get
            {
                var inductor = new Inductor();
                inductor.Name = textBoxNameInductor.Text;
                try
                {
                    inductor.Value = Convert.ToDouble(textBoxInductance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Error Inductance");
                    throw exception;
                }
                return inductor;
            }

            set
            {
                textBoxInductance.Text = value.Value.ToString();
                textBoxNameInductor.Text = value.Name;

                try
                {
                    double textBoxInductor = Convert.ToDouble(textBoxInductance.Text);
                }
                catch (FormatException)
                {
                    var exception = new FormatException(@"Errror Inductance");
                    throw exception;
                }
            }
        }

        /// <summary>
        /// Заполнение поля имени индуктивного элемента
        /// </summary>
        /// <param name="nameInductor"></param>
        public void ChangeNameInductor(string nameInductor)
        {
            textBoxNameInductor.Text = nameInductor;
        }
    }
}
