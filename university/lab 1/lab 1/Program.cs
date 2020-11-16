using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();

            pr.FirstQuestion();

           // pr.SecondQuestion();

           // pr.ThirdQuestion();
        }

        public void FirstQuestion()
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
                $"xn = { s1},\n" + $"xK = { s2},\n" + $"dx = { s3},\n" + $"a = { s4},\n" + $"b = { s5}");
            while (xk >= x)
            {
                y = (Math.Atan(Math.Sqrt(b + x))) / (0.3 * Math.Exp(-a * x) - Math.Sin(a * x));
                Console.WriteLine("If x = " + x + ", y = " + y);
                x = x + dx;
            }
        }

        public void SecondQuestion()
        {
            Console.WriteLine("CREDIT CALCULATE");
            double sc, p, sp, sr, pp, srp, t, tn;
            string s1, s2, s3;
            //data enters
            Console.Write("Enter your credit: ");
            s1 = Console.ReadLine();
            sc = Convert.ToDouble(s1);
            Console.Write("Введите срок кредитирования месяцев: ");
            s2 = Console.ReadLine();
            t = Convert.ToDouble(s2);
            Console.Write("Введите годовую процентную ставку: ");
            s3 = Console.ReadLine();
            p = Convert.ToDouble(s3);
            //calculate
            sp = sc;
            p = p / 100;
            pp = p / 12;
            tn = 1;
            srp = sp * pp;
            double i = t;
            do
            {
                sr = (sp * (1 + pp)) / i;
                sp = (sp * (1 + pp)) - sr;
                Console.WriteLine(
                    "На {0} Месяце с суммой оплаты = {1}, \n" +
                    "Сумма остатка долга = {2} \n\n",
                    tn, sr, sp);
                i--;
                tn++;
                srp = srp + (sp + pp);
            }
            while (i > 1);
            Console.WriteLine(
                "В последний месяц сумма оплаты = {0}; " +
                "\n общая сумма переплаты = {1}\n\n",
                sr, srp);
        }

        public void ThirdQuestion()
        {

            double x1, x2, d, a, b, c, x;

            string s1, s2, s3;

            Console.WriteLine("Введите a = ");
            s1 = Console.ReadLine();
            a = Convert.ToDouble(s1);

            Console.WriteLine("Введите b = ");
            s2 = Console.ReadLine();
            b = Convert.ToDouble(s2);

            Console.WriteLine("Введите c = ");
            s3 = Console.ReadLine();
            c = Convert.ToDouble(s3);

            d = (b * b) - (4 * a * c);

            x = -b / (2 * a);
            x1 = (-b + Math.Sqrt(d) / (2 * a));
            x2 = (-b + Math.Sqrt(d) / (2 * a));

            if (b > 0) if (c > 0) { Console.WriteLine("При {0}*x^2+{1}*x+{2}=0", a, b, c); };
            if (b > 0) if (c < 0) { Console.WriteLine("При {0}*x^2+{1}*x+{2}=0", a, b, c); };
            if (b < 0) if (c > 0) { Console.WriteLine("При {0}*x^2+{1}*x+{2}=0", a, b, c); };
            if (b < 0) if (c < 0) { Console.WriteLine("При {0}*x^2+{1}*x+{2}=0", a, b, c); };
            if (d < 0) { Console.WriteLine("Корней нет!"); };
            if (d == 0) Console.WriteLine("Один корень х={0}", x);
            else Console.WriteLine("Два корня х1={0}, x2={1}", x1, x2);

        }

    }
}
