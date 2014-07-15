using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.First_encapsulate_
{
    /// <summary>
    /// 简单的类的封装
    /// </summary>
    public class Operation
    {
        public static double GetResult(double operationNum1,double operationNum2,string operatorStr) 
        {
            double result=0d;
            switch (operatorStr)
            { 
                case "+":
                    result = operationNum1 + operationNum2;
                    break;
                case "-":
                    result = operationNum1 - operationNum2;
                    break;
                case "*":
                    result = operationNum1 * operationNum2;
                    break;
                case "/":
                    if (operationNum2 == 0)
                    {
                        result = -99;
                    }
                    else
                    {
                    result = operationNum1 / operationNum2;
                    }
                    break;
                default:
                    result = -99;
                    break;
            }
            return result;
        }
    }
}
