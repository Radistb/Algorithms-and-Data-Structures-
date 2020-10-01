using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HH.BL.question2_4
{
    public class Group1CD
    {
        public void coder() {

            //@"E:/Algorithms-and-Data-Structures-/z3.txt"

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

            Console.Clear();
            

            StreamWriter f1 = new StreamWriter(@"E:/Algorithms-and-Data-Structures-/z31.txt");
            string source;
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("Ввести рядок=");

                source = Console.ReadLine();

                foreach (KeyValuePair<string, string> pair in words)
                {
                    source = source.Replace(pair.Key, pair.Value);
                }
                Console.WriteLine(source);
                f1.WriteLine(source);
                
            }
            f1.Close();  //Закрити файловий потік
        }
    }
}
