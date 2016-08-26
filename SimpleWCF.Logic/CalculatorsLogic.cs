using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleWCF.Contract;
using SimpleWCF.Logic.Factory;
using Framework.Service.Infrastructure;

namespace SimpleWCF.Logic
{
    public class CalculatorsLogic : ICalculators
    {
        private ILogger _Ilogger;
        public CalculatorsLogic(ILogger logger)
        {
            _Ilogger = logger;
        }
        public string Add(double numberA, double numberB)
        {
            IOperatorFactory add = new AddFactory();
            Operator addOperator = add.CreareOperator();
            addOperator.NumberA = numberA;
            addOperator.NumberB = numberB;
            return addOperator.GetResult().ToString();

        }

        public string Subtract(double numberA, double numberB)
        {
            IOperatorFactory subtract = new SubtractFactory();
            Operator subtractOperator = subtract.CreareOperator();
            subtractOperator.NumberA = numberA;
            subtractOperator.NumberB = numberB;
            return subtractOperator.GetResult().ToString();
        }

        public string Multiply(double numberA, double numberB)
        {
            IOperatorFactory multiply = new MultiplyFactory();
            Operator multiplyOperator = multiply.CreareOperator();
            multiplyOperator.NumberA = numberA;
            multiplyOperator.NumberB = numberB;
            return multiplyOperator.GetResult().ToString();
        }

        public string Divide(double numberA, double numberB)
        {
            string result = string.Empty;
            try
            {
                IOperatorFactory divide = new DivideFactory();
                Operator divideOperator = divide.CreareOperator();
                divideOperator.NumberA = numberA;
                divideOperator.NumberB = numberB;
                result = divideOperator.GetResult().ToString();
            }
            catch (Exception ex)
            {
                _Ilogger.Log(LogLevel.Error, ex);
            }
            return result;
        }
    }
}
