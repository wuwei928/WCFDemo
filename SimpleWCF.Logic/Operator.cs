using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic
{
    public class Operator
    {
        private double _numberA;
        public double NumberA
        {
            get { return _numberA; }
            set { _numberA = value; }
        }

        private double _numberB;
        public double NumberB
        {
            get { return _numberB; }
            set { _numberB = value; }
        }

        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }

    }
}
