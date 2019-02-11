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
  
        static void Main(string[] args)
        {
            string fileName="test.txt";
            string path="C:/Users/ww/photo/1";
            string path1="C:/Users/ww/photo/2";

            string sourceFile=Path.Combine(path,fileName);
            string destFile=Path.Combine(path1,fileName);

           FileStream fs=File.Create(sourceFile);
            
            fs.Close();
            
            

             if (Directory.Exists(path))
        {
            string[] files = Directory.GetFiles(path);

            // Copy the files and overwrite destination files if they already exist.
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                fileName = Path.GetFileName(s);
                
                File.Copy(s, destFile, true);
            }
        }
        
        
        if(Directory.Exists("C:/Users/ww/photo/1"))
          try
        {
            Directory.Delete("C:/Users/ww/photo/1",true);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
            
            Console.ReadKey();
        }
    }
}
