using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleWCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.CalculatorsClient client = new CalculatorService.CalculatorsClient();
           string result= client.Add(2, 2);
           Console.WriteLine(result);
           Console.Read();
        }
    }
}
