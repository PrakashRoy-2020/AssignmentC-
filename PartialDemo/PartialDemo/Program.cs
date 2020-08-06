using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    partial class Program
    {
        //declaration p-method
        static partial void Show();
        static void Main(string[] args)
        {
            Show();
        }
    }
    partial class Program
    {
        //p-method empliments
        static partial void Show()
        {
            Console.WriteLine("partial method");
        }
    }
}
