using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            var result = Add2(20,30);

            Console.WriteLine(result);


   
            Console.ReadKey();

        }

        static void Add()
        {
            Console.WriteLine("ADDDDDDD!");
        }
        static int Add2(int nummber1 , int number2)
        {
           int result = nummber1 + number2;

            return result;
        }
    }
}
