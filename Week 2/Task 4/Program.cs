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
            string fileName="test.txt";  //name of file that will be copied 
            string path="C:/Users/ww/photo/1";  //path of sourcefile
            string path1="C:/Users/ww/photo/2"; //path of file where we can see copied file at the end

            string sourceFile=Path.Combine(path,fileName); //Combine the path with new file
            string destFile=Path.Combine(path1,fileName);  //combine the path1 with file that will be copied to 

           FileStream fs=File.Create(sourceFile); //Create a fileName file in path
            
            fs.Close();
            
            

             if (Directory.Exists(path))  //condition 
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
        
        
        if(Directory.Exists("C:/Users/ww/photo/1"))  //condition of existing path
          try  
        {
            Directory.Delete("C:/Users/ww/photo/1",true);  //calling delete fuction of directory 
        }
        catch (IOException e)   //Initializes a new instance of the IOException class
        {
            Console.WriteLine(e.Message); //Gets a message that describes the current exception	

        }
            
            Console.ReadKey();
        }
    }
}
