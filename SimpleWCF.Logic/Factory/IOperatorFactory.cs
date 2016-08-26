using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Logic.Factory
{
   public interface IOperatorFactory
    {
       Operator CreareOperator();
    }
}
