using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSCalc
{
    static class MathService
    {
        public static double Sum(double num1,double num2)
        {
            return num1 + num2;
        }
        public static double Subtract(double num1,double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1,double num2)
        {
            return num1 / num2;
        }
    }   
}
