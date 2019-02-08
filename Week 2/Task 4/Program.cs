using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_4
{
    class Program
    {
       private static void Ex1()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww\photo");
            var folders = dir.GetDirectories();
            foreach(var i in folders)
            {
                Console.WriteLine(i.Name);
            }
        }
        static void Main(string[] args)
        {
            Ex1();
        }
    }
}
