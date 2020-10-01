using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HH.BL.question2_5
{
    public class Group1DC
    {
        //@"E:/Algorithms-and-Data-Structures-/z3.txt"
        public void decoder()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            words.Add("а", "q");
            words.Add("б", "w");
            words.Add("в", "e");
            words.Add("г", "r");
            words.Add("д", "t");
            words.Add("е", "y");
            words.Add("ё", "u");
            words.Add("ж", "i");
            words.Add("з", "o");
            words.Add("и", "p");
            words.Add("й", "a");
            words.Add("к", "s");
            words.Add("л", "d");
            words.Add("м", "f");
            words.Add("н", "g");
            words.Add("о", "h");
            words.Add("п", "j");
            words.Add("р", "k");
            words.Add("с", "l");
            words.Add("т", "z");
            words.Add("у", "x");
            words.Add("ф", "c");
            words.Add("х", "v");
            words.Add("ч", "b");
            words.Add("ш", "n");
            words.Add("щ", "m");
            words.Add("ю", "<");
            words.Add("я", ">");
            words.Add("ц", "?");
            words.Add("ъ", ".");
            words.Add("ы", "_");
            words.Add("ь", "=");
            words.Add("э", ",");
            words.Add("і", ":");
            words.Add("ї", ";");

            //E:/Algorithms-and-Data-Structures-/z31.txt

            Console.Write("Ввести путь к файлу=");

            string source = Console.ReadLine();

            StreamReader sr = new StreamReader(source);
            foreach (KeyValuePair<string, string> pair in words)
            {
                source = source.Replace(pair.Key, pair.Value);
            }

            string line;

            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
