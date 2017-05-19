using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Elements.View
{
    public partial class ElementListForm : Form
    {
        /// <summary>
        /// Список элементов
        /// </summary>
        private List<IElement> _elements { get; set; }

        /// <summary>
        /// Хранит в себе информацию о проэкте
        /// </summary>
        private ElementsProject ElementsProject { get; set; }

        /// <summary>
        /// Объект класса бинарной сериализации
        /// </summary>
        private BinaryFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Сериализует и десериализует файлы
        /// </summary>
        private SerializeElement _serializeElement = new SerializeElement();
        

        /// <summary>
        /// Имя файла
        /// </summary>
        private string _fileName = "C:\\Users\\User\\Documents\\New List";

        /// <summary>
        /// Флаг сохранения
        /// </summary>
        private bool _saveFile = false;

        /// <summary>
        /// Главная форма
        /// </summary>
        public ElementListForm(string[] args)
        {
            InitializeComponent();
            
            if (args.Length > 0)
            {
                using (var fs = new FileStream(args[0], FileMode.OpenOrCreate))
                {

                    var elementsProject = (ElementsProject)formatter.Deserialize(fs);

                    ElementsProject = elementsProject;

                    textBoxAngularFrequency.Text = ElementsProject.AngularFrequency.ToString();
                    _fileName = ElementsProject.FileName;
                    Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - SPO Laboratory Works";

                    for (int i = 0; i < ElementsProject.Elements.Count; i++)
                    {
                        elementDataGridView.Rows.Add(ElementsProject.Elements[i].Name, ElementsProject.Elements[i].Value,
                            ElementsProject.Elements[i].GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));

                    }
                }
            }
            

            Text = _fileName;
            _elements = new List<IElement>();
#if !DEBUG
            buttonRandom.Visible = false;
#endif
            Text = FileNameGenerate.GenerateFileName(_fileName);
            ElementsProject = new ElementsProject();
            ElementsProject.Elements = _elements;
            ElementsProject.AngularFrequency = Convert.ToDouble(textBoxAngularFrequency.Text);
            ElementsProject.FileName = _fileName;

        }

        public sealed override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }


        /// <summary>
        /// Добавить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxAngularFrequency.TextLength == 0)
            {
                MessageBox.Show(@"The angular fequency must not be empty");
                return;
            }
            double angular = Convert.ToDouble(textBoxAngularFrequency.Text);

            if (angular != 0)
            {
                var form = new ElementForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var element = form.Element;
                    if (element == null)
                    {
                        return;
                    }
                    ElementsProject.Elements.Add(element);

                    if (element is Resistor)
                    {
                        elementDataGridView.Rows.Add(element.Name, element.Value,
                                element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                    }
                    if (element is Inductor)
                    {
                        elementDataGridView.Rows.Add(element.Name, element.Value,
                                element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                    }
                    if (element is Capacitor)
                    {
                        elementDataGridView.Rows.Add(element.Name, element.Value,
                                element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                    }
                    Text = FileNameGenerate.AsteriskChange(true, _fileName);
                    _saveFile = true;
                }
            }
        }


        /// <summary>
        /// Удалить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (ElementsProject.Elements.Count == 0)
            {
                return;
            }
            var resultRemove = MessageBox.Show(@"Are you sure you want to delete this element?", 
                @"Remove",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            switch (resultRemove)
            {
                case DialogResult.Yes:
                {
                    int index = elementDataGridView.SelectedCells[0].RowIndex;
                    elementDataGridView.Rows.RemoveAt(index);
                    ElementsProject.Elements.RemoveAt(index);
                    break;
                }
                case DialogResult.No:
                {
                    return;
                }
            }
            Text = FileNameGenerate.AsteriskChange(true, _fileName); ;
            _saveFile = true;
        }

        /// <summary>
        /// Пересчитать угловую частоту
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxAngularFrequency.TextLength == 0)
            {
                MessageBox.Show(@"The angular frequency must not be empty");
                return;
            }

            try
            {

                double angular = Convert.ToDouble(textBoxAngularFrequency.Text);

                for (int i = 0; i < ElementsProject.Elements.Count; i++)
                {
                    elementDataGridView.Rows[i].Cells[2].Value =
                        ElementsProject.Elements[i].GetImpedance(Convert.ToDouble((angular)));
                }
                Text = FileNameGenerate.AsteriskChange(true, _fileName);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Wrong format frequency");
            }
            _saveFile = true;
        }

        /// <summary>
        /// Изменить элемент
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (ElementsProject.Elements.Count == 0)
            {
                return;
            }

            int index = elementDataGridView.SelectedCells[0].RowIndex;

            var form = new ElementForm
            {
                Element = ElementsProject.Elements[index]
            };
            form.ShowDialog();
            var element = form.Element;
            ElementsProject.Elements.RemoveAt(index);
            ElementsProject.Elements.Insert(index, element);
            elementDataGridView.Rows.RemoveAt(index);

            if (element is Resistor)
            {
                elementDataGridView.Rows.Insert(index, element.Name, element.Value,
                        element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
            }
            if (element is Inductor)
            {
                elementDataGridView.Rows.Insert(index, element.Name, element.Value,
                        element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
            }
            if (element is Capacitor)
            {
                elementDataGridView.Rows.Insert(index, element.Name, element.Value,
                        element.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
            }
            _saveFile = true;
        }
        
        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ElementsProject.FileName = _fileName;
            ElementsProject.AngularFrequency = Convert.ToDouble(textBoxAngularFrequency.Text);
            _serializeElement.Serilization(ElementsProject);
            Text = FileNameGenerate.AsteriskChange(false, _fileName);
            _saveFile = false;
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var elementsProject = _serializeElement.Deserilization();
                if (ElementsProject == null)
                {
                    return;
                }

                ElementsProject.Elements.Clear();
                elementDataGridView.Rows.Clear();

                ElementsProject = elementsProject;
;
                textBoxAngularFrequency.Text = ElementsProject.AngularFrequency.ToString();
                _fileName = ElementsProject.FileName;
                Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - SPO Laboratory Works";

                for (int i = 0; i < ElementsProject.Elements.Count; i++)
                {
                    elementDataGridView.Rows.Add(ElementsProject.Elements[i].Name, ElementsProject.Elements[i].Value,
                        ElementsProject.Elements[i].GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));

                }
                _saveFile = false;
            }
            catch (SerializationException)
            {
                MessageBox.Show(@"Error with File");
            }
        }

        /// <summary>
        /// Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Добавление случайного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRandom_Click(object sender, EventArgs e)
        {
            try
            {
                var newRandomElements = RandomElementGenerate.CreateRandomElement();
                ElementsProject.Elements.Add(newRandomElements);

                if (newRandomElements is Resistor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameResistor();
                    elementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                            newRandomElements.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                }
                if (newRandomElements is Inductor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameInductor();
                    elementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                            newRandomElements.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                }
                if (newRandomElements is Capacitor)
                {
                    newRandomElements.Name = ElementNameGenerate.GenerateNameCapacitor();
                    elementDataGridView.Rows.Add(newRandomElements.Name, newRandomElements.Value,
                            newRandomElements.GetImpedance(Convert.ToDouble(textBoxAngularFrequency.Text)));
                }

                this.Text = FileNameGenerate.AsteriskChange(true, _fileName);
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Angular frequency must be more than zero");
            }
            _saveFile = true;
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click_1(object sender, EventArgs e)
        {
            var form = new SearchForm(ElementsProject.Elements.ToList(), textBoxAngularFrequency.Text);
            form.Show();

        }

        /// <summary>
        /// Новый список
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ElementsProject.Elements.Count == 0)
            {   
                var saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fileName = saveFileDialog.FileName;
                    Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - SPO Laboratory Works";
                }
                else
                {
                    return;
                }
                return;
            }
            var resultNewElement = MessageBox.Show(@"Do you want to save this file?", @"New file", 
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            
            switch (resultNewElement)
            {
                case DialogResult.Yes:
                {
                        ElementsProject.AngularFrequency = Convert.ToDouble(textBoxAngularFrequency.Text);
                        ElementsProject.FileName = _fileName;
                        _serializeElement.Serilization(ElementsProject);
                        ElementsProject.Elements.Clear();
                        elementDataGridView.Rows.Clear();
                        textBoxAngularFrequency.Text = "";
                        _fileName = "C:\\Users\\User\\Documents\\New List";
                        Text = FileNameGenerate.GenerateFileName(_fileName);
                        break;
                    }
                case DialogResult.No:
                    {

                        ElementsProject.Elements.Clear();
                        elementDataGridView.Rows.Clear();
                        textBoxAngularFrequency.Text = "";
                        _fileName = "C:\\Users\\User\\Documents\\New List";
                        Text = FileNameGenerate.GenerateFileName(_fileName);
                        break;
                    }
                case DialogResult.Abort:
                {
                    break;
                }
            }
            _saveFile = false;
        }

        /// <summary>
        /// Закрытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ElementListForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ElementsProject.Elements.Count != 0 && _saveFile)
            {
                var dialogResultForms = MessageBox.Show(@"Do you want to save file?", @"Close file",
                    MessageBoxButtons.YesNoCancel);

                switch (dialogResultForms)
                {
                    case DialogResult.Yes:
                    {
                        ElementsProject.AngularFrequency = Convert.ToDouble(textBoxAngularFrequency.Text);
                        ElementsProject.FileName = _fileName;
                        _serializeElement.Serilization(ElementsProject);
                        break;
                    }
                    case DialogResult.Cancel:
                    {
                        e.Cancel = true;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Сохранить как
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = @"txt files (*.el)|*.el";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _fileName = saveFileDialog.FileName;
                Text = _fileName.Substring(_fileName.LastIndexOf("\\") + 1) + @" - SPO Laboratory Works";
            }
            else
            {
                return;
            }
            ElementsProject.AngularFrequency = Convert.ToDouble(textBoxAngularFrequency.Text);
            ElementsProject.FileName = _fileName;
            _serializeElement.Serilization(ElementsProject);
            Text = FileNameGenerate.AsteriskChange(false, _fileName);
            _saveFile = false;
        }
    }
}
