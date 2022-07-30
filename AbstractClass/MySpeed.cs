using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractClass
{
    class MySpeed:PhisicFormula
    {
        public override int Speed(int s, int t)
        {
            int v = s * t;
            return v;
        }

        public override int Power(int m, int a)
        {
            throw new NotImplementedException();
        }

        public override string Answer(string answer)
        {
            string str = "Скорость=" + answer;
            return str;
        }
    }
}
