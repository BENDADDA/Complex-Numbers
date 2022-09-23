using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace System
{
    namespace Matlab
    {
        /// <summary>
        /// 
        /// </summary>
        class Polynomial
        {
            Complex[] X;
            
            int Degree;
            public Polynomial(params Complex[] x)
            {
                Degree = x.Length - 1;
                X = new Complex[x.Length];
                for (int i = 0; i <= Degree; i++)
                    X[i] = x[i];
            }
            public Complex f(Complex z)
            {
                Complex s = 0;
                for (int i = 0; i <= Degree; i++)
                    s += X[i] * Maths.Power(z, Degree - i);
                return s;
            }


        }
    }
}