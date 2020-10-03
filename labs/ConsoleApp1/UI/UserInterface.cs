using ConsoleApp1.Bl;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1.UI
{
    public class UserInterface
    {
        public void interfaceView()
        {

            Bl.Decoder decoder = new Bl.Decoder();
            Bl.Coder coder = new Bl.Coder();

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
                {
                    mode = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    mode = 0;
                    Console.WriteLine("Ошибка!");
                    break;
                }
                switch (mode)
                {
                    case 1:
                        mode = 1;
                        {
                            Console.WriteLine("Extra options\n");
                            Console.WriteLine("Enter file name:");
                            string fileIn = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine("Enter output file name:");
                            string fileOut = Console.ReadLine();
                            coder.encode(fileIn, fileOut);
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
                            decoder.decode(fileIn, fileOut);
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
