using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatic.models
{
    internal static class Calculatrice
    {

        internal const double PI = 3.141596;

        public static int Addition(int a , int b)
        {
            return a + b;
        }

        public static int Soustraction(int a, int b)
        {
            return a - b;
        }

        public static int Division(int a, int b)
        {
            if(b == 0)
            {
                return 0;
            }
            else
            {
                return a / b;

            }
        }

        public static int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
