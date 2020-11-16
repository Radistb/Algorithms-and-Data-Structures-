using System;
using System.Collections.Generic;
using System.Text;

namespace HH.BL.question1
{
    public class FirstQuestion
    {
        public void Calculate()
        {
            double xn, xk, dx, a, b;
            double y = 0.0;
            string s1, s2, s3, s4, s5;
            Console.WriteLine("Введите xn = ");
            s1 = Console.ReadLine();
            xn = Convert.ToDouble(s1);
            double x = xn;
            Console.WriteLine("Введите xk = ");
            s2 = Console.ReadLine();
            xk = Convert.ToDouble(s2);
            Console.WriteLine("Введите dx = ");
            s3 = Console.ReadLine();
            dx = Convert.ToDouble(s3);
            Console.WriteLine("Введите a = ");
            s4 = Console.ReadLine();
            a = Convert.ToDouble(s4);
            Console.WriteLine("Введите b = ");
            s5 = Console.ReadLine();
            b = Convert.ToDouble(s5);
            Console.WriteLine($"Input Data: \n" +
                $"xn = { s1},\n" +
                $"xK = { s2},\n" +
                $"dx = { s3},\n" +
                $"a = { s4},\n" +
                $"b = { s5}");

            while (xk >= x)
            {
                y = (System.Math.Sin(x - a))
                                /
                    (System.Math.Exp(a - x)
                                +
                    (System.Math.Sqrt(System.Math.Abs(b * x))));

                Console.WriteLine("If x = " + x + ", y = " + y);

                x = x + dx;
            }
        }
    }
}
