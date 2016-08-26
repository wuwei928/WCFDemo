using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic.Factory
{
    public class DivideFactory : IOperatorFactory
    {

        public Operator CreareOperator()
        {
            return new Divide();
        }
    }
}
