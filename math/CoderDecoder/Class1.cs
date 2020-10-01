using System;
using System.IO;

namespace CoderDecoder
{
    public class Class1
    {
        public void reader() {
            StreamReader sr = new StreamReader("../TestFile.txt");

            string line;
            //читаємо і відображаємо на екрані рядки тексту з файла
            // поки не досягнемо кінця файла
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

    }
}
