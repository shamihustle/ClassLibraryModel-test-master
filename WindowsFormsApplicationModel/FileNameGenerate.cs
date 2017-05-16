using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elements.View
{
    static class FileNameGenerate
    {

        /// <summary>
        /// Обрезает полное имя файла и подставялет название
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        static public string GenerateFileName(string fileName)
        {
            return fileName.Substring(fileName.LastIndexOf("\\") + 1) + " - SPO Laboratory Works";
        }

        /// <summary>
        /// Отражение измения файла
        /// </summary>
        static public string AsteriskChange(bool _asterisk, string fileName)
        {
            switch (_asterisk)
            {
                case true:
                    {
                        return fileName.Substring(fileName.LastIndexOf("\\") + 1) + "(*) - SPO Laboratory Works";
                    }
                case false:
                    {
                        return GenerateFileName(fileName);
                    }
            }
            return null;
        }
    }
}
