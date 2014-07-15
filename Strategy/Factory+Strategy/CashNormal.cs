﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Factory_Strategy
{
    class CashNormal:CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }
}
