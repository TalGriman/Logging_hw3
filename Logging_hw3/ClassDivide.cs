using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logging_hw3
{
    static class ClassDivide
    {

        public static double DivideFunc(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new DivideByZeroException("Attempted to divide by zero - function 'DivideFunc'");
            }
            return num1 / num2;
        }
    }
}
