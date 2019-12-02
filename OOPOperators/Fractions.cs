using System;

namespace OOPOperators
{
    class Fraction
    {
        protected long Numerator;
        protected long Denominator;

        public Fraction(long numerator)
        {
            Numerator = numerator;
            Denominator = 1;
        }
        public Fraction(long numerator, long denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
            Fix();
            Simplify();
        }
        public Fraction(double numerator)
        {
            while (numerator - (long)numerator != 0)
            {
                numerator *= 10;
            }
            Numerator = (long)numerator;
            long denominator = 10;
            while (numerator / denominator >= 10)
            {
                denominator *= 10;
            }
            Denominator = (long)denominator;
        }
        public Fraction(double numerator, double denominator)
        {
            while (numerator > (long)numerator || denominator > (long)denominator)
            {
                numerator *= 10;
                denominator *= 10;
            }
            Numerator = (long)numerator;
            Denominator = (long)denominator;
            Fix();
            Simplify();
        }
        public void Simplify()
        {
            if (Numerator % Denominator == 0)
            {
                Numerator /= Denominator;
                Denominator /= Denominator;
            }
            else if (Math.Abs(Numerator) >= Math.Abs(Denominator))
            {
                bool test; long GCD = 1, divisible = Denominator, divider = Numerator % Denominator;
                do
                {
                    test = true;
                    if (divisible % divider == 0)
                    {
                        GCD = divider;
                        test = false;
                    }
                    else
                    {
                        long tmp = divider;
                        divider = divisible % divider;
                        divisible = tmp;
                    }
                } while (test);
                Numerator /= GCD;
                Denominator /= GCD;
            }
        }
        public static implicit operator double(Fraction a)
        {
            return (double)a.Numerator / a.Denominator;
        }
        public void Fix()
        {
            if ((Denominator <= 0 && Numerator <= 0) || (Denominator <= 0 && Numerator >= 0))
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
        public static Fraction operator !(Fraction a)
        {
            Fraction res = new Fraction(a.Denominator, a.Numerator);
            res.Fix();
            return res;
        }
     

        public static Fraction operator +(Fraction obj)
        {
            return obj;
        }
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.Numerator, a.Denominator);
        }


        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(a.Numerator * b.Denominator +
                a.Denominator * b.Numerator, a.Denominator * b.Denominator);
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
            Fraction res = new Fraction(a.Numerator * b.Denominator -
                a.Denominator * b.Numerator, a.Denominator * b.Denominator);
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
            Fraction res = new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
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

        public static bool operator >(Fraction a, Fraction b)
        {
            return a > b;
        }
        public static bool operator >(Fraction a, long b)
        {
            return a > new Fraction(b);
        }
        public static bool operator >(long a, Fraction b)
        {
            return new Fraction(a) > b;
        }
        public static bool operator >(Fraction a, double b)
        {
            return a > new Fraction(b);
        }
        public static bool operator >(double a, Fraction b)
        {
            return new Fraction(a) > b;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            return a < b;
        }
        public static bool operator <(Fraction a, long b)
        {
            return a < new Fraction(b);
        }
        public static bool operator <(long a, Fraction b)
        {
            return new Fraction(a) < b;
        }
        public static bool operator <(Fraction a, double b)
        {
            return a < new Fraction(b);
        }
        public static bool operator <(double a, Fraction b)
        {
            return new Fraction(a) < b;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return a >= b;
        }
        public static bool operator >=(Fraction a, long b)
        {
            return a >= new Fraction(b);
        }
        public static bool operator >=(long a, Fraction b)
        {
            return new Fraction(a) >= b;
        }
        public static bool operator >=(Fraction a, double b)
        {
            return a >= new Fraction(b);
        }
        public static bool operator >=(double a, Fraction b)
        {
            return new Fraction(a) >= b;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a <= b;
        }
        public static bool operator <=(Fraction a, long b)
        {
            return a <= new Fraction(b);
        }
        public static bool operator <=(long a, Fraction b)
        {
            return new Fraction(a) <= b;
        }
        public static bool operator <=(Fraction a, double b)
        {
            return a <= new Fraction(b);
        }
        public static bool operator <=(double a, Fraction b)
        {
            return new Fraction(a) <= b;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        }
    }
}
