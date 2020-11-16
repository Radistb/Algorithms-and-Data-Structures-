using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.Bl
{
    public class Coder
    {
        public void encode(string fileIn, string fileOut)
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
                string f1 = Console.ReadLine();//read from file source

                foreach (KeyValuePair<string, string> pair in dictionary)
                {
                    fileIn = fileIn.Replace(pair.Key, pair.Value);//encode from source to final file
                }
               
                Console.WriteLine();
                finalFile.WriteLine(fileOut);//
            }
            finalFile.Close();
            sourceFile.Close();  //Закрити файловий потік
        }
    }
}
