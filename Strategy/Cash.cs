using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Strategy.Factory_Strategy;

namespace Strategy
{
    public partial class Cash : Form
    {
        public Cash()
        {
            InitializeComponent();
            InitDiscountType();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //double currentResult=GetResult();
            //string outputStr=string.Format("单价:{0},数量:{1},总计:{2}",txtPrice.Text,txtNum.Text,currentResult);
            /*  策略模式+简单工厂模式测试代码
            CashSuper csuper = new CashReturn(300, 100);
            CashContext cc = new CashContext(cbxDiscountType.SelectedItem.ToString());
            double currentResult = cc.acceptCash(Convert.ToDouble(txtPrice.Text) * Convert.ToInt32(txtNum.Text));
            string outputStr = string.Format("单价:{0},数量:{1},总计:{2}", txtPrice.Text, txtNum.Text, currentResult);
            lbxList.Items.Add(outputStr);
            lblResult.Text =(Convert.ToDouble(lblResult.Text)+currentResult).ToString();
             */
            //CashContext cc = new CashContext();



        }
        private void InitDiscountType()
        {
            cbxDiscountType.Items.AddRange(new object[] {"不打折","打八折","满三百送一百"});
            cbxDiscountType.SelectedIndex = 0;
        }
        private double GetResult()
        {
            double result = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(txtNum.Text);
            int cbxDiscountType=lbxList.SelectedIndex;
            switch(cbxDiscountType)
            {
                case 0:
                    result = result * 1;
                    break;
                case 1:
                    result = result * 0.8;
                    break;
                case 2:
                    result = result * 0.6;
                    break;
            }
            return result;
        }
    }
}
