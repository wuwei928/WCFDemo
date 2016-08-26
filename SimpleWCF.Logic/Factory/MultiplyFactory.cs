using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic.Factory
{
    public class MultiplyFactory:IOperatorFactory
    {

        public Operator CreareOperator()
        {
            return new Multiply();
        }
    }
}
