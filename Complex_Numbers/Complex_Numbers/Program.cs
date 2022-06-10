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
            Complex z,w,q,c;
            z = new Complex(0.5,0);
            w = new Complex(-1, 0);           
            Console.WriteLine(w.Sqrt());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            //z->z^2+c
            c = new Complex(0.25,0);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(z);
                z = z * z +c;
            }

            Console.ReadKey();
        }
    }
}
