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
       
        static void PrintInfo(FileSystemInfo f,int k)
            {
            string line=new string(' ',k);
            line=line+f.Name;
            Console.WriteLine(line);
            if(f.GetType() == typeof(DirectoryInfo))
                {
                var items=(f as DirectoryInfo).GetFileSystemInfos();
                foreach(var i in items)
                    {
                    PrintInfo(i,k+4);
                    }
                }
            }
           
       

        static void Main(string[] args)
        { 
            DirectoryInfo d = new DirectoryInfo("C:/Users/ww/photo");
                PrintInfo(d, 1);
          
            Console.ReadKey();
        }
        
    }
}
