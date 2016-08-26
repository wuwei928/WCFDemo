using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleWCF.Logic;

namespace SimpleWCF.Logic.Factory
{
   public class AddFactory:IOperatorFactory
    {
        public Operator CreareOperator()
        {
            return new Add();
        }
    }
}
