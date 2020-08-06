using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialDemo
{
    class LinqDemo
    {
        static void Main()
        {
            string path = @"c:\windows";
            ShowLargeFileWithoutLinq(path);
            ShowLargeFileWithLinq(path);
        }
        private static void ShowLargeFileWithLinq(string path)
        {
            var query = from file in new DirectoryInfo(path).GetFiles() orderby file.Length descending select file;
            foreach (FileInfo file in query)
            {
                Console.WriteLine("{0}{1}", file.Name, file.Length);
                
            }
            foreach(var file in query.Take(5))
            {
                Console.WriteLine($"{file.Name} : {file.Length}");
            }
        }
        private static void ShowLargeFileWithoutLinq(string path)
        {
            DirectoryInfo dir = new DirectoryInfo(path);
            FileInfo[] fio = dir.GetFiles();
            Array.Sort(fio, new FileInfoComparer());
            foreach(FileInfo i in fio)
            {
                Console.WriteLine($"{i.Name} : {i.Length}");
            }
        }
        public class FileInfoComparer : IComparer<FileInfo>
        {
            public int Compare(FileInfo x,FileInfo y)
            {
                return y.Length.CompareTo(x.Length);
            }
        }
    }
}
