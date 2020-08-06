using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class Person
    {
        public void Display()
        {

        }
    }
    static class DemoCls
    {
        //extension method
        public static int Add(this int x,int y)
        {
            return x + y;
        }
        public static string AddStr(this string x, string y)
        {
            return x + y;
        }
        public static void Show(this Person p)
        {
            Console.WriteLine("person class ext method");
        }
    }
    class ExtensionDemo
    {
        static void Main()
        {
            int i = 10;
            var res=i.Add(5);
            Console.WriteLine(res);

            string s = "good";
            var res1 = s.AddStr("morning");
            Console.WriteLine(res1);

            Person p1 = new Person();
            p1.Show();

            string str1 = "this is a string";
            var res2=str1.All(a => a.Equals('s'));
            Console.WriteLine(res2);
        }
        
    }
}
