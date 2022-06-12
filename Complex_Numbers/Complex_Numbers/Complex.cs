using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex_Numbers
{
    class Complex
    {
        public double x { get; set; }
        public double y { get; set; }
        public double ABS { get { return Abs(); } }
        public double ARG { get { return Arg(); } }
        public Complex EXP { get { return Exp(); } }
        public Complex LOG { get { return Log(); } }
        public Complex COS { get { return Cos(); } }
        public Complex SIN { get { return Sin(); } }
        public Complex TAN { get { return Sin() / Cos(); } }
        public Complex ATAN { get { return 1 / TAN; } }
        public Complex SQRT { get { return Sqrt(); } }
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

            return new Complex(a-z.x , -z.y);
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
            double d = w.x * w.x + w.y * w.y;
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
        public static Complex operator ^(Complex z, double n)
        {
            if (n == 0) return new Complex(1, 0);
            if (z.x == 0 && z.y == 0) return new Complex(0, 0);
            return (n * (z.LOG)).EXP;
        }
        public static Complex operator ^(Complex z, Complex n)
        {
            if (n.x == 0 && n.y == 0) return new Complex(1, 0);
            if (z.x == 0 && z.y == 0) return new Complex(0, 0);
            return (n * (z.LOG)).EXP;
        }
        private double Abs()
        {
            return Math.Sqrt(x * x + y * y);
        }
        private double Arg()
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
        private Complex Pow(double n)
        {
           
            if (n == 0) return new Complex(1,0);
            if (x == 0 && y == 0) return new Complex(0,0);
            double a,b;
            a = Math.Pow(Abs(),n) * Math.Cos(n * Arg());
            b = Math.Pow(Abs(), n) * Math.Sin(n * Arg());
            return new Complex(a, b);
        }
        
        private Complex Exp()
        {
            double a, b;
            a = Math.Exp(x) * Math.Cos(y);
            b = Math.Exp(x) * Math.Sin(y);
            return new Complex(a, b);
        }
        private Complex Log()
        {
            double a, b;
            a = Math.Log(Abs());
            b = Arg();
            return new Complex(a, b);
        }
        private Complex Cos()
        {
            Complex i = new Complex(0, 1);
            Complex e1, e2;
            e1 = (Arg() * i).Exp();
            i = new Complex(0, -1);
            e2 = (Arg() * i).Exp();

            return (e1 + e2) / 2;
            
        }
        private Complex Sin()
        {
            Complex i = new Complex(0, 1);
            Complex e1, e2;
            e1 = (Arg() * i).Exp();
            i = new Complex(0, -1);
            e2 = (Arg() * i).Exp();

            return (e1 - e2) / 2;

        }
        private Complex Sqrt()
        {
            double a = (x + Math.Sqrt(x * x + y * y)) / 2;
            double b = Math.Sqrt(a - x);
            return new Complex(Math.Sqrt(a), b);
        }
        public override string ToString()
        {
            
            double a, b;
            a = Math.Round(x,2);
            b = Math.Round(y,2);
            return "(" + a + "," + b + ")";
                  
        }
        public static Complex Parse(string str)
        {
            int i; string a, b = "0";
            if (str.Contains(','))
            {
                i = str.IndexOf(",");
                a = str.Substring(0, i);
                b = str.Substring(i + 1, str.Length - a.Length - 1);

            }
            else a = str;

            return new Complex(double.Parse(a), double.Parse(b));
        }
        
    }
}
