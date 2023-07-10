using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] students = new string[3] { "Fatih", "Yavuz", "Emir" };

            //string[] students2 = { "Fatih", "Yavuz", "Emir" };
            ////students2[3] = "Ahmet";

            //foreach (var student in students2)
            //{
            //    Console.WriteLine(student);
            //}



            string[,] regions = new string[5, 3]
            {
                {"istanbul","balıkesir","izmit"},
                {"ankara","sivas","Kırklareli"},
                {"İzmir","Aydın","Bursa"},
                {"urfa","Gaziantep","Diyarbakır"},
                {"Antalya","Karaman","Mersin"},

            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("************");
            }




            Console.ReadKey();

        }
    }
}
