using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Factory_Strategy
{
    class CashReturn:CashSuper
    {
        double returnCondition = 0.0d;
        double returnMoney = 0.0d;
        public CashReturn(double returnCondition,double returnMoney)
        {
            this.returnCondition = returnCondition;
            this.returnMoney=returnMoney;
        }

        public override double acceptCash(double money)
        {
            if (money >= this.returnCondition)
            {
                money = money - (money / returnCondition) * returnMoney;
            }
            return money;
        }
    }
}
