using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class ListExtension
    {
        static void Main()
        {
            List<string> lt = new List<string>(new string[] {"sa","sb","sc","sd"});
            foreach(var i in lt)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------");
            //concat
            List<string> lt1 = new List<string>(new string[] { "a1", "b1", "c1", "d1" });

            var resconcat=lt.Concat(lt1);
            foreach(var i in resconcat) {
                Console.WriteLine(i);
            }
            Console.WriteLine("------");
            //all
            var res2 = lt.All(a => a.Equals('s'));
            Console.WriteLine(res2);
            Console.WriteLine("------");
            //avarage
            List<double> lt2 = new List<double>(new double[] {10,22,30,49});
            var res3 = lt2.Average();
            Console.WriteLine(res3);
            Console.WriteLine("------");
            //any
            List<double> lt3 = new List<double> { 1.2, 1.7, 2.5, 2.4 };
      
            var res4 = lt3.Any(a => a < 1);
            Console.WriteLine(res4);
            Console.WriteLine("------");
            //first
            var res5 = lt3.First();
            Console.WriteLine(res5);
            Console.WriteLine("------");
            //firstordefault
            List<int> lt4 = new List<int> { };
            var res6 = lt4.FirstOrDefault();
            Console.WriteLine("Default value="+res6);
            if(res6 == 0)
            {
                res6 = 1;
            }
            
            Console.WriteLine("Default value change="+res6);
            
            


        }
    }
}
