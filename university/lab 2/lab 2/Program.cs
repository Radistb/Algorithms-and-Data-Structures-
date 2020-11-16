using System;
using System.Collections.Generic;
using System.IO;

namespace lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();

            pr.interfaceView();
        }

        public void encode(string fileSource)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("а", "q");
            dictionary.Add("б", "w");
            dictionary.Add("в", "e");
            dictionary.Add("г", "r");
            dictionary.Add("д", "t");
            dictionary.Add("е", "y");
            dictionary.Add("ё", "u");
            dictionary.Add("ж", "i");
            dictionary.Add("з", "o");
            dictionary.Add("и", "p");
            dictionary.Add("й", "a");
            dictionary.Add("к", "s");
            dictionary.Add("л", "d");
            dictionary.Add("м", "f");
            dictionary.Add("н", "g");
            dictionary.Add("о", "h");
            dictionary.Add("п", "j");
            dictionary.Add("р", "k");
            dictionary.Add("с", "l");
            dictionary.Add("т", "z");
            dictionary.Add("у", "x");
            dictionary.Add("ф", "c");
            dictionary.Add("х", "v");
            dictionary.Add("ч", "b");
            dictionary.Add("ш", "n");
            dictionary.Add("щ", "m");
            dictionary.Add("ю", "<");
            dictionary.Add("я", ">");
            dictionary.Add("ц", "?");
            dictionary.Add("ъ", ".");
            dictionary.Add("ы", "_");
            dictionary.Add("ь", "=");
            dictionary.Add("э", ",");
            dictionary.Add("і", ":");
            dictionary.Add("ї", ";");


            Console.Clear();

            Console.WriteLine("Введить строку, для шифрування:");

            string source;
            //Відкрити файловий потік для запису
            StreamWriter f1 = new StreamWriter(fileSource);

            //Зчитатирядокз клавіатури
            source = Console.ReadLine();


            foreach (KeyValuePair<string, string> pair in dictionary)
            {
                source = source.Replace(pair.Key, pair.Value);
            }
            //виведення зчитаного рядка у файл
            f1.WriteLine(source);
            Console.WriteLine(source);

            f1.Close();  //Закрити файловий потік
        }

            

         public void decode(string fileIn, string fileOut)
        {

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("а", "q");
            dictionary.Add("б", "w");
            dictionary.Add("в", "e");
            dictionary.Add("г", "r");
            dictionary.Add("д", "t");
            dictionary.Add("е", "y");
            dictionary.Add("ё", "u");
            dictionary.Add("ж", "i");
            dictionary.Add("з", "o");
            dictionary.Add("и", "p");
            dictionary.Add("й", "a");
            dictionary.Add("к", "s");
            dictionary.Add("л", "d");
            dictionary.Add("м", "f");
            dictionary.Add("н", "g");
            dictionary.Add("о", "h");
            dictionary.Add("п", "j");
            dictionary.Add("р", "k");
            dictionary.Add("с", "l");
            dictionary.Add("т", "z");
            dictionary.Add("у", "x");
            dictionary.Add("ф", "c");
            dictionary.Add("х", "v");
            dictionary.Add("ч", "b");
            dictionary.Add("ш", "n");
            dictionary.Add("щ", "m");
            dictionary.Add("ю", "<");
            dictionary.Add("я", ">");
            dictionary.Add("ц", "?");
            dictionary.Add("ъ", ".");
            dictionary.Add("ы", "_");
            dictionary.Add("ь", "=");
            dictionary.Add("э", ",");
            dictionary.Add("і", ":");
            dictionary.Add("ї", ";");

            StreamReader sourceFile = new StreamReader(fileIn);
            StreamWriter finalFile = new StreamWriter(fileOut);

            for (int i = 0; i <= 1; i++)
            {
                string f1 = Console.ReadLine();

                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    fileIn = fileIn.Replace(pair.Value, pair.Key);
                }

                Console.WriteLine();
                finalFile.WriteLine(fileOut);//
            }
            finalFile.Close();
            sourceFile.Close();  //Закрити файловий потік
        }

        public void interfaceView()
        {
            int mode = 0;
            List<String> fileData = new List<String>();
            while (mode == 0 || mode >= 3)
            {
                Console.WriteLine("Data Coder Programm \n");
                Console.WriteLine("1. Encode\n");
                Console.WriteLine("2. Decode\n");
                Console.WriteLine("3. Help\n\n");
                Console.WriteLine("Введите цифру для выбора: >>>");
                try
                { mode = int.Parse(Console.ReadLine()); }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка!");
                    break;
                }
                switch (mode)
                {
                    case 1:
                        mode = 1;
                        {
                            Console.WriteLine("Ввести путь до файлу для запису:");
                            string fileIn = Console.ReadLine();
                            Console.WriteLine();
                            encode(fileIn);
                        }
                        break;
                    case 2:
                        mode = 2;
                        {
                            Console.WriteLine("Extra options\n");
                            Console.WriteLine("Enter file name:");
                            string fileIn = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter output file name:");
                            string fileOut = Console.ReadLine();
                            decode(fileIn, fileOut);
                        }
                        break;
                    case 3:
                        mode = 3;
                        {
                            Console.WriteLine("Help");
                        }
                        break;
                }
            }
        }
    }
}
