using System;

namespace HomeWork8._5
{
    /* Суханов
     * **Написать программу-преобразователь из CSV в XML-файл с информацией о студентах (6 урок).
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Преобразователь из CSV в XML-файл с информацией о студентах");

            CsvConvertXmlBase.Converter("..\\..\\students_0.csv", "..\\..\\students_1.xml");

            Console.WriteLine("Работа программы завершена!");
            Console.ReadLine();
        }
    }
}
