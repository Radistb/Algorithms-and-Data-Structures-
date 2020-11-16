
using HH.BL.question1;
using HH.BL.question2;
using HH.BL.question3;
using System;
using System.Collections.Generic;
using System.IO;

namespace HH.BL
{
    public class Program
    {
        public static void Main()
        {
            FirstQuestion first = new FirstQuestion();
            SecondQuestion second = new SecondQuestion();
            ThirdQuestion third = new ThirdQuestion();

            first.Calculate();
            second.Calculate();
            third.Calculate();
        }
    }
}












