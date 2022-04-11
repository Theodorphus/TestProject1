using System;

namespace TestProject1
{
    public class Calculator
    {
        public static Double Add(double x, double y)
        {
            return x + y;
        }


     
        public static Double Add(double[] x, double[] y)
        {

      

            return x[0] + y[0]; 
          
        }

        public static Double Subtract(double x, double y)
        {
            return x - y;
        }

        public static Double Subtract(double[] x, double[] y)
        {



            return x[0] - y[0];

        }

        public static Double Multiply(double x, double y)
        {
            return x * y;
        }

        public static Double Divide(double x, double y)
        {
            if (y != 0)
            {
                return x / y;
            }
            else
            {
                return 0;
            }

        }
    }
}