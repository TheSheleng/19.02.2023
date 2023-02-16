using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02._2023
{
    internal struct Fraction
    {
        int numerator;
        int denominator;

        Fraction(int n, int d) { numerator = n; denominator = d; }
        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(
                f1.numerator + f2.numerator, 
                f1.denominator + f2.denominator
            );
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(
                f1.numerator - f2.numerator,
                f1.denominator - f2.denominator
            );
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(
                f1.numerator * f2.numerator,
                f1.denominator * f2.denominator
            );
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            return new Fraction(
                f1.numerator / f2.numerator,
                f1.denominator / f2.denominator
            );
        }
    }
}
