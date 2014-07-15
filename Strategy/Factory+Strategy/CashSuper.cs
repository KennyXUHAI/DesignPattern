using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Factory_Strategy
{
    abstract class CashSuper
    {
        /// <summary>
        /// 抽象收银函数
        /// </summary>
        /// <param name="money">原本应收金额总数</param>
        /// <returns>返回活动后实际应收金额总数</returns>
        public abstract double acceptCash(double money);
    }
}
