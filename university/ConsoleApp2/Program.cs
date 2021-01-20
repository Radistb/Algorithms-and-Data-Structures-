using ConsoleApp2.View;
using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        delegate void method();
        static void Main(string[] args)
        {


            int index = 0;

            ArrayList Menu1_Items = new ArrayList();
            Menu1_Items.Add("Help");
            Menu1_Items.Add("File");
            Menu1_Items.Add("Edit");
            Menu1_Items.Add("Exit");



            VerticalNav Menu = new VerticalNav(Menu1_Items, false, 50, 20);
            index = Menu.Show(0);
            Console.WriteLine(index);
            Console.ReadLine();      
        }
    }
}
    