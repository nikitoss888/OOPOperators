using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPOperators
{
    class Fraction
    {
        protected long Numerator;
        protected long Denumenator;

        public Fraction(long numerator, long denumenator)
        {
            Numerator = numerator;
            Denumenator = denumenator;
        }
        public Fraction(long numerator)
        {
            Numerator = numerator;
            Denumenator = 1;
        }
        public Fraction(double a)
        {
            while (a - (int)a != 0)
            {
                a *= 10;
            }
            Numerator = (int)a;
            int b = 10;
            while (a / b >= 10)
            {
                b *= 10;
            }
            Denumenator = b;
        }
        public void Simplify()
        {

        }
        public static Fraction operator +(Fraction obj)
        {
            return obj;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denumenator);
        }
        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.Numerator * b.Denumenator +
                a.Denumenator * b.Numerator, a.Denumenator * b.Denumenator);
            res.Simplify();
            res.Fix();
            return res;
        }
        public static Fraction operator +(Fraction a, long b)
        {
            return a + new Fraction(b);
        }
        public static Fraction operator +(long a, Fraction b)
        {
            return new Fraction(a) + b;
        }
        public static Fraction operator +(Fraction a, double b)
        {
            return a + new Fraction(b);
        }
        public static Fraction operator +(double a, Fraction b)
        {
            return new Fraction(a) + b;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.Numerator * b.Denumenator -
                a.Denumenator * b.Numerator, a.Denumenator * b.Denumenator);
            res.Simplify();
            res.Fix();
            return res;
        }
        public static Fraction operator -(Fraction a, long b)
        {
            return a - new Fraction(b);
        }
        public static Fraction operator -(long a, Fraction b)
        {
            return new Fraction(a) - b;
        }
        public static Fraction operator -(Fraction a, double b)
        {
            return a - new Fraction(b);
        }
        public static Fraction operator -(double a, Fraction b)
        {
            return new Fraction(a) - b;
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.Numerator * b.Numerator, a.Denumenator * b.Denumenator);
            res.Simplify();
            res.Fix();
            return res;
        }
        public static Fraction operator *(Fraction a, long b)
        {
            return a * new Fraction(b);
        }
        public static Fraction operator *(long a, Fraction b)
        {
            return new Fraction(a) * b;
        }
        public static Fraction operator *(Fraction a, double b)
        {
            return a * new Fraction(b);
        }
        public static Fraction operator *(double a, Fraction b)
        {
            return new Fraction(a) * b;
        }
        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction res = a * !b;
            res.Simplify();
            return res;
        }
        public static Fraction operator /(Fraction a, long b)
        {
            return a * !(new Fraction(b));
        }
        public static Fraction operator /(long a, Fraction b)
        {
            return new Fraction(a) * !b;
        }
        public static Fraction operator /(Fraction a, double b)
        {
            return a * !(new Fraction(b));
        }
        public static Fraction operator /(double a, Fraction b)
        {
            return new Fraction(a) * !b;
        }

        public static Fraction operator !(Fraction a)
        {
            Fraction res = new Fraction(a.Denumenator, a.Numerator);
            res.Fix();
            return res;
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a == b;
        }
        public static bool operator ==(Fraction a, long b)
        {
            return a == new Fraction(b);
        }
        public static bool operator ==(long a, Fraction b)
        {
            return new Fraction(a) == b;
        }
        public static bool operator ==(Fraction a, double b)
        {
            return a == new Fraction(b);
        }
        public static bool operator ==(double a, Fraction b)
        {
            return new Fraction(a) == b;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return a != b;
        }
        public static bool operator !=(Fraction a, long b)
        {
            return a != new Fraction(b);
        }
        public static bool operator !=(long a, Fraction b)
        {
            return new Fraction(a) != b;
        }
        public static bool operator !=(Fraction a, double b)
        {
            return a != new Fraction(b);
        }
        public static bool operator !=(double a, Fraction b)
        {
            return new Fraction(a) != b;
        }
        public override string ToString()
        {
            return $"{Numerator}/{Denumenator}";
        }
        public void Fix()
        {
            if ((Denumenator <= 0 && Numerator <= 0) || (Denumenator <= 0 && Numerator >= 0))
            {
                Numerator = -Numerator;
                Denumenator = -Denumenator;
            }
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denumenator;
        }
    }
}
