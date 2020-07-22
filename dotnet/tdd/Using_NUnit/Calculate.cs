using System;

namespace Using_NUnit
{
    public class Calculate
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public double Potecia(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}