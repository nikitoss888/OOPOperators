using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OOPOperators
{
    class Class1
    {
        public static void Main()
        {
            Fraction a = new Fraction(3);
            Fraction res = a;
            WriteLine(res.ToString());
            res = -a;
            WriteLine(res.ToString());
            a = new Fraction(1.2, 1.02);
            res = a;
            WriteLine(res.ToString());
            Fraction b = new Fraction(-89, 23);
            res = a + b;
            WriteLine(res.ToString());
            res = a - b;
            WriteLine(res.ToString());
            Fraction c = new Fraction(2, -5);
            res = a / c;
            WriteLine(res.ToString());
            a = new Fraction(5.12);
            res = a;
            WriteLine(res.ToString());
            b = new Fraction(1, -19);
            res = b;
            WriteLine(res.ToString());
        }
    }
}
