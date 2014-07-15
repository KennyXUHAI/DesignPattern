using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Strategy.Factory_Strategy
{
    #region 收银策略类
    /// <summary>
    /// 收银策略类
    /// </summary>
    class CashContext
    {
        CashSuper cs= null;

        /// <summary>
        /// 普通构造函数
        /// </summary>
        /// <param name="cs">商场促销实例对象</param>
        public CashContext(CashSuper cs)
        {
            this.cs = cs;
        }

        /// <summary>
        /// 简单工厂构造函数（这里是简单策略模式和简单工厂模式结合的关键点）
        /// </summary>
        /// <param name="rebateType">商场促销类型</param>
        public CashContext(string rebateType)
        {
            switch (rebateType)
            { 
                case "不打折":
                    this.cs = new CashNormal();
                    break;
                case "打八折":
                    this.cs = new CashRebate(0.8);
                    break;
                case "满三百送一百":
                    this.cs=new CashReturn(300,100);
                    break;
            }
        }

        /// <summary>
        /// 收银函数
        /// </summary>
        /// <param name="money">原本应收金额</param>
        /// <returns>实际应收金额</returns>
        public double acceptCash(double money)
        {
            return cs.acceptCash(money);
        }
    }
    #endregion
}
