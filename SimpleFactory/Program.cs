using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using SimpleFactory.First_encapsulate_;
using SimpleFactory.Second_encapsulate_inherit_polymorphic_;
namespace SimpleFactory
{
    class Program
    {
        /// <summary>
        /// 此函数完成计算器的简单计算
        /// </summary>
        /// <param name="args">输入参数</param>
        static void Main(string[] args)
        {
            /*
            GetResult();        //利用简单的函数完成计算器功能

            //下面是利用类的封装完成计算机功能
            //利用简单的封装完成了业务的封装，使得程序之间的耦合性大大降低，可维护性大大增强，程序变得可复用和可扩展
            Console.Write("Please input the num A:");
            string a = Console.ReadLine();
            Console.Write("Please input the operator:");
            string operatorStr=Console.ReadLine();
            Console.Write("Please input the num B:");
            string b = Console.ReadLine();
            double result = Operation.GetResult(Convert.ToDouble(a), Convert.ToDouble(b), operatorStr);
            Console.Write(result.ToString());
            Console.ReadKey();
             * */
            Console.Write("Please input the num A:");
            string a = Console.ReadLine();
            Console.Write("Please input the operator:");
            string operatorStr = Console.ReadLine();
            Console.Write("Please input the num B:");
            string b = Console.ReadLine();
            Operation oper = OperationFactory.CreateOperation(operatorStr);
            oper.NumberA = Convert.ToDouble(a);
            oper.NumberB = Convert.ToDouble(b);
            double result = oper.GetResult();
            Console.Write(result.ToString());
            Console.ReadKey();
        }
        public static void GetResult()
        {
            int result = 0;
            try
            {
                Console.Write("Please input the num A:");
                string a = Console.ReadLine();
                Console.Write(@"Please input the operator(=,-,*,\):");
                string operatorStr = Console.ReadLine();
                Console.Write("Please input the num B:");
                string b = Console.ReadLine();
                switch (operatorStr)
                {
                    case "+":
                        result = Convert.ToInt32(a) + Convert.ToInt32(b);
                        break;
                    case "-":
                        result = Convert.ToInt32(a) - Convert.ToInt32(b);
                        break;
                    case "*":
                        result = Convert.ToInt32(a) * Convert.ToInt32(b);
                        break;
                    case "/":
                        if (Convert.ToInt32(b) == 0)
                        {
                            Console.Write("The divisor is not to be zero!");
                        }
                        else
                        {
                            result = Convert.ToInt32(a) / Convert.ToInt32(b);
                        }
                        break;
                    default:
                        Console.WriteLine("Parameter Error!");
                        break;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            Console.WriteLine("The result is:" + result.ToString());
            Console.ReadKey();
        }
    }
}
