using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniräknare
{
    public class Numbers
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public Numbers(double num1, double num2)
        {
            Number1 = num1;
            Number2 = num2;
        }
        public double Add()
        {
            double ans = Number1 + Number2;
            return ans;
        }
        public double Multiply()
        {
            double ans = Number1 * Number2;
            return ans;
        }
        public double Divide()
        {
            double ans = Number1 / Number2;
            return ans;
        }
        public double Subtract()
        {
            double ans = Number1 - Number2;
            return ans;
        }
        public double Square()
        {
            double ans = Math.Pow(Number1, 2);
            return ans;
        }
    }
}
