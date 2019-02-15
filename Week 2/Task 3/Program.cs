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
       
        static void PrintInfo(FileSystemInfo f,int k) //to Print the names of files and directories 
            {
            string line=new string(' ',k); 
            string newline=line+f.Name;
            Console.WriteLine(newline);
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
            DirectoryInfo d = new DirectoryInfo("C:/Users/ww/photo"); //to point out the directory
                PrintInfo(d, 1);//1 is the index where writing will be started
          
            Console.ReadKey();
        }
        
    }
}
