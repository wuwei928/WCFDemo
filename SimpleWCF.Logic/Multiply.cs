using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic
{
    public class Multiply : Operator
    {
        public override double GetResult()
        {
            double result = NumberA * NumberB;
            return result;

        }
    }
}
