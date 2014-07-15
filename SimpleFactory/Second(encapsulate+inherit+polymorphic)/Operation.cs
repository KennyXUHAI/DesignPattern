﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory.Second_encapsulate_inherit_polymorphic_
{
    public class Operation
    {
        public double numberA = 0;
        public double numberB = 0;

        public double NumberA
        {
            get { return numberA; }
            set { numberA = value; }
        }
        public double NumberB
        {
            get { return numberB; }
            set { numberB = value; }
        }

        public virtual double GetResult()
        {
            double result=0;
            return result;
        }
    }
}
