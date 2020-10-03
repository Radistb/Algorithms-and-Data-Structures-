using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HH.BL.question2_4
{                //E:/Algorithms-and-Data-Structures-/z31.txt

    public class UserInterface
    {
        Dictionary<char, char> dictionary = new Dictionary<char, char>(

            ("а", "q"),
            ("б", "w"),
            ("в", "e"),
            ("г", "r"),
            ("д", "t"),
            ("е", "y"),
            ("ё", "u"),
            ("ж", "i"),
            ("з", "o"),
            ("и", "p"),
            ("й", "a"),
            ("к", "s"),
            ("л", "d"),
            ("м", "f"),
            ("н", "g"),
            ("о", "h"),
            ("п", "j"),
            ("р", "k"),
            ("с", "l"),
            ("т", "z"),
            ("у", "x"),
            ("ф", "c"),
            ("х", "v"),
            ("ч", "b"),
            ("ш", "n"),
            ("щ", "m"),
            ("ю", "<"),
            ("я", ">"),
            ("ц", "?"),
            ("ъ", "."),
            ("ы", "_"),
            ("ь", "="),
            ("э", ","),
            ("і", ":"),
            ("ї", ";"));
        public static void navigation()
        {

            Console.Clear();
            Console.WriteLine("Coder example");

            Console.Write("Enter your message: ");
            string dataInput = encode(Console.ReadLine());
            Console.WriteLine("Decoded message{0}", dataInput);

            int mode = 0;

            List<string> fileData = new List<string>();

            while (mode == 0 || mode > 3)
            {
                Console.WriteLine("Data Coder Programm \n");
                Console.WriteLine("1. Encode\n");
                Console.WriteLine("2. Decode\n");
                Console.WriteLine("3. Help\n\n");
                Console.WriteLine("Введите цифру для выбора: >>>");
                try
                {
                    mode = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    mode = 0;
                }
            }
            Console.WriteLine("Extra options\n");
            Console.WriteLine("Enter file name:");
            string fileIn = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter output file name:");
            string fileOut = Console.ReadLine();
            StreamReader reader = new StreamReader(fileIn);
            StreamWriter writer = new StreamWriter(fileOut);

            string line;
            switch (mode)
            {
                case 1:
                    mode = 0;
                    while (mode = 0 || mode > 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Choose encoding method\n");
                        Console.WriteLine("1.Permutation\n");
                        Console.WriteLine("2.Change\n");
                        Console.Write(">>>");
                        try
                        {
                            mode = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            mode = 0;
                        }
                    }
                    while ((line = reader.ReadLine()) != null)
                    {
                        fileData.Add(line);
                    }
                    reader.Close();
                    switch (mode)
                    {
                        case 1:
                            foreach (string li in fileData)
                            {
                                writer.WriteLine(decode(li));
                            }
                            writer.Close();
                            break;
                        case 2:
                            foreach (string li in fileData)
                            {
                                char[] charsli = li.ToCharArray();
                                for (int i = 0; i < charsli.Length; i++)
                                {
                                    charsli(i) = (char)(charsli[i] - 40);
                                }
                                writer.WriteLine(new string(charsli));
                            }
                            writer.Close();
                            break;
                    }
                    break;
            }
        }
        static string encode(string dataInput)
        {
            char[] chars = dataInput.ToCharArray();
            for (int i = 0; i <= chars.Length - 1; i++)
            {
                if (dictionary.ContainsKey(chars[i]))
                {
                    chars[i] = dictionary[chars[i]];
                }
            }
            return new string(chars);
        }
        static string decode(string dataInput)
        {
            char[] chars = dataInput.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                if(dictionary.ContainsValue(chars[i]))
                {
                    foreach(KeyValuePair<char, char> pair in dictionary)
                    {
                        if(pair.Value.Equals(chars[i]))
                        {
                            chars[i] = pair.Key;
                            break;
                        }
                    }
                }
                return new string(chars);
            }
        }
    }
}
