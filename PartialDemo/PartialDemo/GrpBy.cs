using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace PartialDemo
{
    public class Student
    {
        public int Age { get; set; }
        public string Name { get; set; }
    }
    class GrpBy
    {
        static void Main()
        {
        var stul = new List<Student>() {
        new Student() { Name = "Sam", Age = 18 } ,
        new Student() { Name = "Prakash",  Age = 21 } ,
        new Student() { Name = "Dev",  Age = 18 } ,
        new Student() { Name = "Ram" , Age = 20 } ,
        new Student() { Name = "Roy" , Age = 21 }
    };

            var result = from s in stul
                                group s by s.Age;

            
            //foreach(var i in result)
            //{
            //    Console.WriteLine(i);
            //}
            //IEnumerator<Student> ie = stul.GetEnumerator();
            //while (ie.MoveNext())
            //{
            //    Console.WriteLine(ie.Current.Age);
            //}
            //iterate each group        
            foreach (var a in result)
            {
                Console.WriteLine("Age: {0}", a.Key);

                foreach (Student s in a) 
                    Console.WriteLine("Student Name: {0}", s.Name);
            }
        }
    }
}
