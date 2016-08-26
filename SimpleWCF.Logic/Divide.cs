using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic
{
    public class Divide : Operator
    {
        public override double GetResult()
        {
            double result = NumberA / NumberB;
            if (NumberB == 0)
            {
                throw new InvalidOperationException("The NumberB can't be 0");
            }
            return result;
        }
    }
}
