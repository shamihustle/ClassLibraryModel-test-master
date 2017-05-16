using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
    using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elements;
using Elements.View.Controls;


namespace Elements.View
{
    public partial class ElementForm : Form
    {
        /// <summary>
        /// Элемент
        /// </summary>
        public IElement Element
        {
            get
            {
                try
                {
                    var cathThrowElements = elementsControl.Elements;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    return null;
                }
                return elementsControl.Elements;
            }

            set
            {
                try
                {
                    elementsControl.Elements = value;
                }
                catch (FormatException exception)
                {
                    MessageBox.Show(exception.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// Конструктор формы добавления элемента
        /// </summary>
        public ElementForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выход Cancel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// Выход Ok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
