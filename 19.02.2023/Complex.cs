using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2023
{
    internal struct Complex
    {
        public int RealPart { get; private set; }
        Complex(int n) { RealPart = n; }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.RealPart + c2.RealPart);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.RealPart - c2.RealPart);
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.RealPart * c2.RealPart);
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            return new Complex(c1.RealPart / c2.RealPart);
        }
    }
}