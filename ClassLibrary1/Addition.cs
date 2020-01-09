using System;

namespace ClassLibrary1
{
    public class Addition
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static double Sum(double a, double b)
        {
            return a + b;
        }
        public static double sum(double[] arrayA)

        {
            double c = 0.0;
            foreach (double a in arrayA)
            {
                c = sum(a, c);
            }
            return c;
        }
    }
}
