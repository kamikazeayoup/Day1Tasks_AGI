using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public static class Calculator
    {
    
        public static int Sum(int first , int second) { 
        return first + second;
        }
        public static int Subtract(int first, int second)
        {
            return first - second;
        }
        public static int Multiplie(int first, int second)
        {
            return first * second;
        }
        public static int Division(int first, int second)
        {
            if (second == 0)
                throw new DivideByZeroException();

            return first * second;
        }
    }


    
}
