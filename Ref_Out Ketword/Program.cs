using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ref_Out_Ketword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 50;
            var result=Add(out a, b);

            Console.WriteLine(result);
            Console.WriteLine(a);

            Console.ReadKey();

        }


        static int Add( out int a, int b) 
        {
            a = 1;
            return a + b; 
        }
    }
}
