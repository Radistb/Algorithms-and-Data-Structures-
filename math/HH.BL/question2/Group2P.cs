using System;
using System.Collections.Generic;
using System.Text;

namespace HH.BL.question2
{
    public class Group2P
    {
        public void Calculate()
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
    }
}
