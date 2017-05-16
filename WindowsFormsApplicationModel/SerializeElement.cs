using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elements;
using System.Numerics;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using NUnit.Framework;

namespace Elements.View
{
    class SerializeElement
    {
        private BinaryFormatter formatter = new BinaryFormatter();

        /// <summary>
        /// Сериализация
        /// </summary>
        /// <param name="elementsProject"></param>
        public void Serilization(ElementsProject elementsProject)
        {
            using (var fs = new FileStream(elementsProject.FileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, elementsProject);
            }
        }

        /// <summary>
        /// Десериализация
        /// </summary>
        /// <returns></returns>
        public ElementsProject Deserilization()
        {
            string filename = string.Empty;
            var openFileDilog = new OpenFileDialog();
            if (openFileDilog.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDilog.FileName;
            }
            else
            {
                return null;
            }

            using (var fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                var elementsProject = (ElementsProject)formatter.Deserialize(fs);

                return elementsProject;
            }
        }
    }
}
