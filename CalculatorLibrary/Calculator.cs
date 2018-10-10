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

        public static double Sum(List<double> numbers)
        {
            double sum = 0;
                
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }

            return sum;
        }


        public static double Minimum(double[] numbers)
        {
            double min = numbers[0];

            for (int i = 1; i < numbers.Length; i = i + 1)
            {
                if (min > numbers[i])
                {
                    min = numbers[i];
                }
            }
            return min;
        }

        public static double Maximum(double[] numbers)
        {
            double max = numbers[0];

            for (int i = 1; i < numbers.Length; i = i + 1)
            {
                if (max < numbers[i])
                {
                    max = numbers[i];
                }
            }
            return max;
        }

        public static double Average(double[] numbers)
        {
            double sum = numbers[0];

            int i = 1;
            while (i < numbers.Length)
            {
                sum = sum + numbers[i];
                i++;
            }

            sum = sum / numbers.Length;

            return sum;
        }
    }
}
