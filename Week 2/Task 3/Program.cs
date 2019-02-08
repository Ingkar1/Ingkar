using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_3
{
    class Program
    {
        /*static void Ex1()
        {

            FileInfo file = new FileInfo("‪C:/Users/ww/Desktop/cafe/cafe.jpg");
            Console.WriteLine(file.Name);
            Console.WriteLine(file.Directory);
            Console.WriteLine(file.FullName);
        }*/
        /*static void Ex2()
        {
            DirectoryInfo directory = new DirectoryInfo("‪C:/Users/ww/Desktop/");
            Console.WriteLine(directory.Name);
            Console.WriteLine(directory.FullName);
            Console.WriteLine(directory.Parent);
        }*/
        /*static void Ex3()
        {
            DirectoryInfo Directory = new DirectoryInfo(" "); 
            FileInfo[] files = Directory.GetFiles();
            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
        }
         public static void PrintSpace(int level)
            {
            for (int i = 0; i < level; i++)
                Console.WriteLine("  ");
             }
        
          
       
        public static void Ex5(DirectoryInfo directory,int level)
        {   
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();
            
            
            foreach(FileInfo file in files)
            {
                PrintSpace(level);
                Console.WriteLine(file.Name);
            }
            foreach(DirectoryInfo d in directories)
            {
                PrintSpace(level);
                Console.WriteLine(d.Name);
                Ex5(d, level + 1);

            }
        }
        */
        static void PrintInfo(FileSystemInfo fsi,int k)
            {
            string line=new string(' ',k);
            line=line+fsi.Name;
            Console.WriteLine(line);
            if(fsi.GetType() == typeof(DirectoryInfo))
                {
                var items=(fsi as DirectoryInfo).GetFileSystemInfos();
                foreach(var i in items)
                    {
                    PrintInfo(i,k+4);
                    }
                }
            }
           
        private static void F()
            {
             DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww\photo");
                PrintInfo(dir, 1);
            }

        static void Main(string[] args)
        {
          F();
            Console.ReadKey();
        }
        
    }
}
