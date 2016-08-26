using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace SimpleWCF.Contract
{
    [ServiceContract]
    public interface ICalculators
    {
        [OperationContract]
        String Add(Double numberA, Double numberB);
        [OperationContract]
        String Subtract(Double numberA, Double numberB);
        [OperationContract]
        String Multiply(Double numberA, Double numberB);
        [OperationContract]
        String Divide(Double numberA, Double numberB);
    }
}
