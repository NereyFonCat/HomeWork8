using System;
using System.Linq;
using System.IO;
using System.Xml.Linq;

namespace HomeWork8._5
{
    internal class CsvConvertXmlBase
    {
        /// <summary>Мэджик код</summary>
        /// <param name="fileNameOpen">Имя csv файла</param>
        /// <param name="fileNameSave">Имя xml файла</param>
        public static void Converter(string fileNameOpen, string fileNameSave)
        {
            string[] lines = File.ReadAllLines(fileNameOpen);
            string[] headers = { "Name", "Surname", "University", "Faculty", "Department", "Age", "Course", "Group", "City" };

            var xml = new XElement("Students",
               lines.Where((line, index) => index > 0).Select(line => new XElement("StudentIndo",
                  line.Split(';').Select((column, index) => new XElement(headers[index], column)))));

            xml.Save(fileNameSave);
        }
    }
}