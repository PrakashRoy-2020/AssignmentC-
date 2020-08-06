using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class IEnumerable
    {
        static void Main()
        {
            IEnumerable<Employee> dev = new Employee[]
            {
                new Employee{Id=1,Name="prakash"},
                new Employee{Id=2,Name="roy"}
            };
            IEnumerable<Employee> sale = new List<Employee>()
            {
                new Employee{Id=3,Name="sam"},
                new Employee{Id=4,Name="ram"}
            };
            Console.WriteLine("Developer-----");

            //same as foreach does
            IEnumerator<Employee> ie = dev.GetEnumerator();
            while(ie.MoveNext()){
                Console.WriteLine(ie.Current.Name);
            }
           
            
            //foreach (var person in dev)
            //{
            //    Console.WriteLine(person.Name);
            //}
            Console.WriteLine("Sales----");
            foreach (var person in sale)
            {
                Console.WriteLine(person.Name);
            }
            var query1 = dev.Where(e => e.Name.Length == 5).OrderBy(e => e.Name).Select(e => e);
            var query2 = from d in dev
                         where d.Name.Length == 5
                         orderby d.Name descending
                         select d;
        }
    }
}
