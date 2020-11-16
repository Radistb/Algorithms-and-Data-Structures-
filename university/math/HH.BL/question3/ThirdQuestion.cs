using System;
using System.Collections.Generic;
using System.Text;

namespace HH.BL.question3
{
    public class ThirdQuestion
    {
        public void Calculate()
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

            d=(b*b)-(4*a*c);

            x=-b / (2*a);
            x1=(-b+Math.Sqrt(d)/(2*a));
            x2=(-b+Math.Sqrt(d)/(2*a));

            if(b>0)if(c>0){Console.WriteLine("При {0}*x^2+{1}*x+{2}=0",a,b,c);};
            if(b>0)if(c<0){Console.WriteLine("При {0}*x^2+{1}*x+{2}=0",a,b,c);};
            if(b<0)if(c>0){Console.WriteLine("При {0}*x^2+{1}*x+{2}=0",a,b,c);};
            if(b<0)if(c<0){Console.WriteLine("При {0}*x^2+{1}*x+{2}=0",a,b,c);};
            if(d<0){Console.WriteLine("Корней нет!");};
            if (d == 0) Console.WriteLine("Один корень х={0}", x);
            else Console.WriteLine("Два корня х1={0}, x2={1}", x1, x2);

        } 
    }
}
