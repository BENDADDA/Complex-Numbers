using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace System
{
    namespace Matlab
    {
        /// <summary>
        ///
        /// </summary>
        public static class Maths
        {

            /// <summary>
            /// Calculating the Niberian Exponent for a Complex Number
            /// </summary>
            /// <param name="z">A complex number specifying a power</param>
            /// <returns>Exp(z)</returns>
            public static Complex Exp(Complex z)
            {
                double a, b;
                a = Math.Exp(z.x) * Math.Cos(z.y);
                b = Math.Exp(z.x) * Math.Sin(z.y);
                return new Complex(a, b);
            }
            /// <summary>
            /// To set the complex number using exponential form
            /// </summary>
            /// <param name="r">r is the modulus of  a complex number</param>
            /// <param name="o">o is the argument of a complex number</param>
            /// <returns></returns>
            public static Complex ExpForm(double r, double o)
            {
                return new Complex(r * Math.Cos(o), r * Math.Sin(o));
            }
            /// <summary>
            /// Returns a value indicating the sign of a complex number
            /// </summary>
            /// <param name="z">A complex number specifying an angle</param>
            /// <returns></returns>
            public static Complex Sign(Complex z)
            {
                return ExpForm(1, z.ARG);
            }
            /// <summary>
            ///Returns the value of the logarithm of a complex number
            /// </summary>
            /// <param name="z">A complex  number  whose logarithm is to be found</param>
            /// <returns></returns>
            public static Complex Log(Complex z)
            {
                double a, b;
                a = Math.Log(z.ABS);
                b = z.ARG;
                return new Complex(a, b);
            }
            /// <summary>
            ///Returns the logarithm of specified complex number in a specified base
            /// </summary>
            /// <param name="z">A complex  number  whose logarithm is to be found</param>
            /// <param name="n">A real nubmer specifies the logarithm base </param>
            /// <returns></returns>
            public static Complex Log(Complex z, double n)
            {
                return Log(z) / Log(n);
            }
            /// <summary>
            /// Returns the logrithm of specified complex number in specified base
            /// </summary>
            /// <param name="z">A complex number whose logarithm is to be found</param>
            /// <param name="n">A complex number specifies the logarithm base</param>
            /// <returns></returns>
            public static Complex Log(Complex z, Complex n)
            {
                return Log(z) / Log(n);
            }
            /// <summary>
            /// Returns base 10 logarithm of specified complex number
            /// </summary>
            /// <param name="z">A complex number whose logarithm is to be found</param>
            /// <returns></returns>
            public static Complex Log10(Complex z)
            {
                return Log(z) / Math.Log(10);
            }
            /// <summary>
            /// Returns the cosine of specified complex number
            /// </summary>
            /// <param name="z"></param>
            /// <returns>A complex number whose cosine to be found</returns>
            public static Complex Cos(Complex z)
            {
                Complex i = new Complex(0, 1);
                Complex e1, e2;
                e1 = Exp((z.ARG * i));
                i = new Complex(0, -1);
                e2 = Exp((z.ARG * i));
                return (e1 + e2) / 2;
            }
            /// <summary>
            /// Returns the sine of specified complex number
            /// </summary>
            /// <param name="z">A complex number whose sine to be found</param>
            /// <returns></returns>
            public static Complex Sin(Complex z)
            {
                Complex i = new Complex(0, 1);
                Complex e1, e2;
                e1 = Exp((z.ARG * i));
                i = new Complex(0, -1);
                e2 = Exp((z.ARG * i));
                return (e1 - e2) / 2;
            }
            /// <summary>
            /// Returns the tangent of specified complex number 
            /// </summary>
            /// <param name="z">A complex number whose tangent to be found</param>
            /// <returns></returns>
            public static Complex Tan(Complex z)
            {
                return Sin(z) / Cos(z);
            }
            /// <summary>
            /// Returns the hyperbolic cosine of specfied complex number
            /// </summary>
            /// <param name="z">A complex number whose hyperbloci cosine of to be found</param>
            /// <returns></returns>
            public static Complex Cosh(Complex z)
            {   
                return (Exp(z) + Exp(-z)) / 2;
            }
            /// <summary>
            /// Returns the hyperbolic tangent of specfied complex number
            /// </summary>
            /// <param name="z">A complex number whose hyperbloci tangent of to be found</param>
            /// <returns></returns>
            public static Complex Tanh(Complex z)
            {
                return Sinh(z) / Cosh(z);
            }
            /// <summary>
            /// Returns the hyperbolic sine of specfied complex number
            /// </summary>
            /// <param name="z">A complex number whose hyperbloci sine of to be found</param>
            /// <returns></returns>
            public static Complex Sinh(Complex z)
            {
                return (Exp(z) - Exp(-z)) / 2;
            }
            /// <summary>
            /// Returns the square root of specified complex nubmer
            /// </summary>
            /// <param name="z">A complex number</param>
            /// <returns></returns>
            public static Complex Sqrt(Complex z)
            {   
                double x = z.x, y = z.y;
                double a = (x + Math.Sqrt(x * x + y * y)) / 2;
                double b = Math.Sqrt(a - x);
                return new Complex(Math.Sqrt(a), b);
            }
            /// <summary>
            /// Return a specified complex nubmber raised to the specified power
            /// </summary>
            /// <param name="z">A complex number to raised a power </param>
            /// <param name="n">A double -precision floating -point number that specifies a power</param>
            /// <returns></returns>
            public static Complex Power(Complex z, double n)
            {   
                if (n == 0) return new Complex(1, 0);
                if (z.x == 0 && z.y == 0) return new Complex(0, 0);
                return Exp(n * Log(z));
            }
            /// <summary>
            /// Return a specified complex nubmber raised to the specified power where the power is a complex number
            /// </summary>
            /// <param name="z">A complex number to raised a power</param>
            /// <param name="n">A complex number that  specifies a power</param>
            /// <returns></returns>
            public static Complex Power(Complex z, Complex n)
            {
                if (n.x == 0 && n.y == 0) return new Complex(1, 0);
                if (z.x == 0 && z.y == 0) return new Complex(0, 0);
                return Exp(n * Log(z));
            }
            /// <summary>
            /// Returns the floor of complex number
            /// </summary>
            /// <param name="z">A complex number</param>
            /// <returns></returns>
            public static Complex Floor(Complex z)
            {
                return new Complex(Math.Floor(z.x), Math.Floor(z.y));
            }
            /// <summary>
            /// Returns the ceiling of complex nubmer
            /// </summary>
            /// <param name="z">A complex number</param>
            /// <returns></returns>
            public static Complex Ceiling(Complex z)
            {
                return new Complex(Math.Ceiling(z.x), Math.Ceiling(z.y));
            }
            /// <summary>
            /// Return a Magic Matrix in a specified dimensions where it is a square matrix
            /// </summary>
            /// <param name="k">k is a natural number specified the dimensions where the dimensions of the magic matrix is 2k+1</param>
            /// <returns></returns>
            public static int[,] MagicMatrix(int k)
            {

                int n = 2 * k + 1;
                int[,] v = new int[n, n];
                int l, c, i, N;
                N = (n - 1) / 2; l = N - 1; c = N; i = 0;
                while (i < n * n)
                {
                    if (l >= 0 && l < n && c >= 0 && c < n)
                    {
                        if (v[l, c] == 0) { v[l, c] = i + 1; i++; l--; c++; }
                        else { l--; c--; }
                    }
                    else g(ref l, ref c, n - 1);
                }
                return v;
            }
            static void g(ref int a, ref int b, int n)
            {
                if (a == n + 1) a = 0;
                if (a == -1) a = n;
                if (b == n + 1) b = 0;
                if (b == -1) b = n;
            }


        }
        /// <summary>
        /// A class representing complex numbers 
        /// </summary>
        public class Complex
        {
            /// <summary>
            /// The real part of the complex number
            /// </summary>
            public double x { get; set; }
            /// <summary>
            /// The imaginary part of a complex number
            /// </summary>
            public double y { get; set; }
            /// <summary>
            /// Modulus of complex number
            /// </summary>
            public double ABS { get { return Abs(); } }
            /// <summary>
            /// Aruement of complex number
            /// </summary>
            public double ARG { get { return Arg(); } }




            /// <summary>
            /// Specifieds the complex number by two real numbers
            /// </summary>
            /// <param name="x">The real part of the complex number</param>
            /// <param name="y">The imaginary part of a complex number</param>
            public Complex(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            /// <summary>
            /// 
            /// </summary>
            public Complex()
            {
            }

            public static Complex operator +(Complex z, Complex w)
            {
                return new Complex(z.x + w.x, z.y + w.y);

            }
            public static Complex operator -(Complex z, Complex w)
            {
                return new Complex(z.x - w.x, z.y - w.y);
            }
            public static Complex operator +(Complex z, double a)
            {

                return new Complex(z.x + a, z.y);
            }
            public static Complex operator -(Complex z, double a)
            {

                return new Complex(z.x - a, z.y);
            }
            public static Complex operator +(double a, Complex z)
            {

                return new Complex(z.x + a, z.y);
            }
            public static Complex operator -(double a, Complex z)
            {

                return new Complex(a - z.x, -z.y);
            }

            public static Complex operator *(Complex z, Complex w)
            {
                return new Complex(z.x * w.x - z.y * w.y, z.x * w.y + z.y * w.x);
            }
            public static Complex operator *(Complex z, double a)
            {
                return new Complex(z.x * a, z.y * a);
            }
            public static Complex operator *(double a, Complex z)
            {
                return new Complex(z.x * a, z.y * a);
            }
            public static Complex operator /(Complex z, Complex w)
            {
                double d = w.x * w.x + w.y * w.y;
                return new Complex((z.x * w.x + z.y * w.y) / d, (z.y * w.x - z.x * w.y) / d);
            }
            public static Complex operator /(double a, Complex z)
            {
                double d = z.x * z.x + z.y * z.y;
                return new Complex((z.x * a) / d, (-z.y * a) / d);
            }

            public static Complex operator /(Complex z, double a)
            {
                return new Complex(z.x / a, z.y / a);
            }
            public static Complex operator -(Complex z)
            {
                return new Complex(-z.x, -z.y);
            }


            public static implicit operator Complex(double x)
            {
                return new Complex(x, 0);
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






           
            public override string ToString()
            {

                double a, b;
                a = Math.Round(x, 2);
                b = Math.Round(y, 2);
                return "(" + a + "," + b + ")";

            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="str"></param>
            /// <returns></returns>
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
            /// <summary>
            /// 
            /// </summary>
            /// <param name="str"></param>
            /// <param name="a"></param>
            /// <returns></returns>
            public static bool TryParse(string str, out Complex a)
            {
                a = new Complex();
                try
                {
                    a = Parse(str);
                    return true;
                }
                catch { }
                return false;
            }

        }
    }
}