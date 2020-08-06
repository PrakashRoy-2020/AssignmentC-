using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class ClsA
    {
        static void Main()
        {
            int[] arr1 = { 10, 20, 30, 40, 50 };
            int[] arr2 = { 5,0,3 };

            
            for(int i = 0; i <= arr1.Length; i++)
            {
                try
                {
                    var res = arr1[i] / arr2[i];
                    Console.WriteLine(res);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

           
        //    foreach(int i in arr1)
        //    {
        //        foreach(int j in arr2)
        //        {
        //            try
        //            {
                        
        //                    var res = i / j;
        //                    Console.WriteLine(res);
                        
                        
        //            }
        //            catch(Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //        }
        //    }
        }
    }
}
