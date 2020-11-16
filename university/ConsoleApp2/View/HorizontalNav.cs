using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2.View
{
    public class HorizontalNav
    {
        public ConsoleColor TextColor = ConsoleColor.White;
        public ConsoleColor FonColor = ConsoleColor.DarkYellow;
        public ConsoleColor MenuColor = ConsoleColor.DarkYellow;
        public ConsoleColor ItemsColog = ConsoleColor.Blue;
        public ArrayList Items = new ArrayList();
        public int x;//початкова позиція меню
        public int y;//початкова позиція меню
        public int w;//ширина меню
        public int h;//висота меню
        public string menuStr;//порожні йрядок меню
        public int index;//обраний елемент меню

        public HorizontalNav(ArrayList s, bool menyType, int xPos, int yPos)
        {

            string tmp;
            this.Items = s;
            x = xPos;
            y = yPos;
            h = this.Items.Count + 1;
            //визначаємо ширину меню
            w = 64;
            for (int i = 0; i < this.Items.Count; i++)
            {
                tmp = (string)this.Items[i];
                if (tmp.Length + 2 > w) { w = tmp.Length + 2; }
            }
            //створення рядків меню
            //довжина коротких рядків збільшуеться до ширини меню
            for (int i = 0; i < Items.Count; i++)
            {
                tmp = " " + (string)Items[i];
                if (tmp.Length < w - 2)
                {
                    for (int k = tmp.Length; k < w - 2; k++) { tmp = tmp + " "; }
                }
                Items[i] = tmp;

            }
            //вимикаємо курсор
            Console.CursorVisible = false;
        }

        //вимикаємо курсор

        public void DrawBackGroundMenu()
        {
            //малюємо основу меню
            {
                //створюєморядок текстудовжиною w
                menuStr = "";
                for (int i = 0; i < w; i++) { menuStr = menuStr + " "; }
                //малюємоосновуменю
                Console.BackgroundColor = MenuColor;
                for (int i = 0; i <= h; i++)
                {
                    Console.SetCursorPosition(x, i + y);
                    Console.Write(menuStr);
                    //return 1;
                }
            }
        }

        public void DrawItemsMenu()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (i == index) Console.BackgroundColor = ItemsColog;
                else Console.BackgroundColor = FonColor;
                Console.SetCursorPosition(x + 1, i + y + 1);
                Console.Write(Items[i]);
                Console.BackgroundColor = MenuColor;
            }
        }

        //скануємо клавішіта переміщуємо курсор
        public void ScanMenu()
        {
            ConsoleKeyInfo key;
            do
            {
                DrawItemsMenu();
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index > 3) index = 0;
                }
                if (key.Key == ConsoleKey.UpArrow)
                {
                    index--;
                    if (index < 0) index = 3;
                }
            } while (key.Key != ConsoleKey.Enter);
        }

        public int Show(int Start)
        {
            index = Start; //малюємо основу меню
            DrawBackGroundMenu(); //малюємо опції
            DrawItemsMenu(); //скануємо клавішітапереміщуємо курсор
            ScanMenu();
            return index;
        }
    }
}


