using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Matlab;

namespace Complex_Numbers
{

    
    class Program
    {
       
        static void Main(string[] args)
        {
            Complex z;
            z = Maths.Sqrt(-1);
            Console.WriteLine("Sqrt({0})={1}",-1,z);
            Console.ReadKey();
        }
    }
}
