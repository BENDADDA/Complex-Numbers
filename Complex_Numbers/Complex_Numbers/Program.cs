using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Complex_Numbers
{
    
    
    class Program
    {
        
        static void Main(string[] args)
        {


            Complex a, b, c, d, x, X, D1, D2, A, B, u, v;
            Console.WriteLine("Solve the third degree equation\nEnter the values of the following variables a,b,c,d");
            Console.Write("a=");
            a = Complex.Parse(Console.ReadLine());
            Console.Write("b=");
            b = Complex.Parse(Console.ReadLine());
            Console.Write("c=");
            c = Complex.Parse(Console.ReadLine());
            Console.Write("d=");
            d = Complex.Parse(Console.ReadLine());

            D1 = (b ^ 2) - 3 * a * c; D2 = (b ^ 3) - 27 * (a ^ 2) * b;
            A = -((b ^ 2) - 3 * a * c) / (3 * (a ^ 2));
            B = -(D2 - 3 * D1 * b) / (27 * (a ^ 3));
            u = (-B / 2 + ((B ^ 2) / 4 + (A ^ 3) / 27).SQRT) ^ (1.0 / 3);
            v = (-B / 2 - ((B ^ 2) / 4 + (A ^ 3) / 27).SQRT) ^ (1.0 / 3);
            X = u + v;
            x = X - b / (3 * a);

            Console.WriteLine(x);
            Console.ReadKey();
        }
    }
}
