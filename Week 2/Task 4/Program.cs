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
       /*private static void Ex1()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ww\photo");
            var folders = dir.GetDirectories();
            foreach(var i in folders)
            {
                Console.WriteLine(i.Name);
            }
        }*/
   
            
        
        public static void DeleteDirectory(string directoryName, bool checkDirectiryExist)
        {
            if (Directory.Exists(directoryName))
                Directory.Delete(directoryName, true);
            else if (checkDirectiryExist)
                throw new SystemException("Directory you want to delete is not exist");
        }
    }
}
        static void Main(string[] args)
        {
            DirectoryInfo yourRootDir = new DirectoryInfo(@"C:\somedirectory\");
            foreach (DirectoryInfo dir in yourRootDir.GetDirectories())
                    DeleteDirectory(dir.FullName, true);
            //Ex1();
            Console.ReadKey();
        }
    }
}
