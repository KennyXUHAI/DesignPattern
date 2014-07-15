using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Second_encapsulate_inherit_polymorphic_
{
    public class OperationFactory
    {
        public static Operation CreateOperation(string operateStr)
        {
            Operation oper=null;
            switch (operateStr)
            { 
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;

            }
            return oper;
        }

    }
}
