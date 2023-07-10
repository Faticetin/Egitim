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
            var result=Add(ref a, b);

            Console.WriteLine(result);
            Console.WriteLine(a);




            int c;
            int e = 50;
            var result2 = Add2(out c, e);

            Console.WriteLine(result);
            Console.WriteLine(a);



            Console.ReadKey();
        }


        static int Add( ref int a, int b) 
        {
            a = 1;
            return a + b; 
        }

        static int Add2(out int c, int e)
        {
            c = 1;
            return c + e;
        }
    }
}
