using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Second_encapsulate_inherit_polymorphic_
{
    class OperationDiv:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            if (NumberB == 0)
                throw new Exception("The divisor is not to be zero!");
            result = NumberA / NumberB;
            return base.GetResult();
        }
    }
}
