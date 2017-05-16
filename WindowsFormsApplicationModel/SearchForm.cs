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

namespace Elements.View
{
    public partial class SearchForm : Form
    {
        /// <summary>
        /// Список для поиска
        /// </summary>
        List<IElement> SearchList = new List<IElement>();

        /// <summary>
        /// Угловая частота
        /// </summary>
        public string AngularFrequency;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="list">Список элементов</param>
        /// <param name="aF">Угловая частота</param>
        public SearchForm(List<IElement> list, string aF)
        {
            SearchList = list;
            AngularFrequency = aF;
            InitializeComponent();

            textBoxSearch.Enabled = false;
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            dataGridViewSearch.Rows.Clear();

            string ss = textBoxSearch.Text;
            string critation = comboBoxSearch.SelectedItem.ToString();
            switch (critation)
            {
                case "Name Element":
                    {
                        foreach (var searchL in SearchList)
                        {
                            if (searchL.Name == ss)
                            {
                                dataGridViewSearch.Rows.Add(searchL.Name, searchL.Value,
                                    searchL.GetImpedance(Convert.ToDouble(AngularFrequency)));
                            }
                        }
                        break;
                    }

                case "Nominal":
                    {
                        foreach (var searchL in SearchList)
                        {
                            if (searchL.Value.ToString() == ss)
                            {
                                dataGridViewSearch.Rows.Add(searchL.Name, searchL.Value,
                                    searchL.GetImpedance(Convert.ToDouble(AngularFrequency)));
                            }
                        }
                        break;
                    }

                case "Impedance":
                    {
                        foreach (var searchL in SearchList)
                        {
                            if (searchL.GetImpedance(Convert.ToDouble(AngularFrequency)).ToString() == ss)
                            {
                                dataGridViewSearch.Rows.Add(searchL.Name, searchL.Value,
                                    searchL.GetImpedance(Convert.ToDouble(AngularFrequency)));
                            }
                        }
                        break;
                    }
            }
        }
        
        
        /// <summary>
        /// Закрыть
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchOk_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void comboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSearch.SelectedItem != null)
            {
                textBoxSearch.Enabled = true;
            }
        }
    }
}
