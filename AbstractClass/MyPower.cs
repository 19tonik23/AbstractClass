using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    public class MyPower:PhisicFormula
    {

        public override int Speed(int s, int t)
        {
            throw new NotImplementedException();
        }

        public override int Power(int m, int a)
        {
            return m * a;
        }

        public override string Answer(string answer)
        {
            return "Сила=" + answer;
        }
    }
}
