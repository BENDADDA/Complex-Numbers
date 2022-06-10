using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex_Numbers
{
    class Complex
    {
        public double x;
        public double y;

        public Complex(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public Complex()
        { 
        }
    
        public static Complex operator +(Complex z, Complex w)
        {      
            return new Complex(z.x+w.x,z.y+w.y);
        }
        public static Complex operator -(Complex z, Complex w)
        {
            return new Complex(z.x - w.x, z.y - w.y);
        }
        public static Complex operator +(Complex z, double a)
        {

            return new Complex(z.x + a, z.y );
        }
        public static Complex operator -(Complex z, double a)
        {

            return new Complex(z.x - a, z.y);
        }
        public static Complex operator +(double a,Complex z)
        {

            return new Complex(z.x + a, z.y);
        }
        public static Complex operator -(double a, Complex z)
        {

            return new Complex(z.x - a, z.y);
        }

        public static Complex operator *(Complex z, Complex w)
        {
            return new Complex(z.x * w.x - z.y * w.y, z.x * w.y + z.y * w.x);
        }
        public static Complex operator *(Complex z, double a)
        {
            return new Complex(z.x * a, z.y*a);
        }
        public static Complex operator *(double a,Complex z)
        {
            return new Complex(z.x * a, z.y * a);
        }
        public static Complex operator /(Complex z, Complex w)
        {
            double d = z.x * w.x + z.y * w.y;
            return new Complex((z.x * w.x + z.y * w.y)/d, (z.y * w.x - z.x * w.y)/d);
        }
        public static Complex operator /(double a, Complex z)
        {
            double d = z.x * z.x + z.y * z.y;
            return new Complex((z.x*a) / d, (-z.y*a) / d);
        }
        public static Complex operator /(Complex z, double a)
        {
            return new Complex(z.x / a, z.y / a);
        }
        public static Complex operator -(Complex z)
        {
            return new Complex(-z.x , -z.y);
        }
        public double Abs()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public double Arg()
        {
            double o;
            o = Math.Asin(y / Abs());
            if (x < 0)
            {
                if (y > 0) o = Math.PI - o;
                else o = -Math.PI - o;
            }
            return o;
        }
        public Complex Pow(double n)
        {
            double a,b;
            a = Math.Pow(Abs(),n) * Math.Cos(n * Arg());
            b = Math.Pow(Abs(), n) * Math.Sin(n * Arg());
            return new Complex(a, b);
        }
        public Complex Exp()
        {
            double a, b;
            a = Math.Exp(x) * Math.Cos(y);
            b = Math.Exp(x) * Math.Sin(y);
            return new Complex(a, b);
        }
        public Complex Log()
        {
            double a, b;
            a = Math.Log(Abs());
            b = Arg();
            return new Complex(a, b);
        }
        public Complex Cos()
        {
            Complex i = new Complex(0, 1);
            Complex e1, e2;
            e1 = (Arg() * i).Exp();
            i = new Complex(0, -1);
            e2 = (Arg() * i).Exp();

            return (e1 + e2) / 2;
            
        }
        public Complex Sin()
        {
            Complex i = new Complex(0, 1);
            Complex e1, e2;
            e1 = (Arg() * i).Exp();
            i = new Complex(0, -1);
            e2 = (Arg() * i).Exp();

            return (e1 - e2) / 2;

        }
        public Complex Sqrt()
        {
            double a = (x + Math.Sqrt(x * x + y * y)) / 2;
            double b = Math.Sqrt(a - x);
            return new Complex(Math.Sqrt(a), b);
        }
        public override string ToString()
        {
            return "(" + x + "," + y + ")";
        }

        
    }
}
