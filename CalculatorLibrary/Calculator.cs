using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public static double Add(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }

        public static double Subtract(double v1, double v2)
        {
            double result = v1 - v2;
            return result;
        }

        public static double Multiply(double v1, double v2)
        {
            double result = v1 * v2;
            return result;
        }

        public static double Divide(double v1, double v2)
        { 
            double result = v1 / v2;
            return result;
        }
         
        public static double Sum(double v1, double v2)
        {
            return 0;
        }

        public static double Sum(double[] numbers)
        {
            double sum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public static double Minimum(double[] numbers)
        {
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }

            }
            return min;
        } 

        public static int Maximum(double[] numbers)
        {
            return 0;
           /* double Maximum = numbers[0];
            for (int i = 1; i > numbers.Length; i++)
            {
                if (Maximum < numbers[i])
                {
                    Maximum = numbers[i];
                }
            }
            return numbers;*/
        }

        public static double Average(double[] numbers)
        {
            return 0;
        }
    }
}
