using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_1
{
    class Program
    {
        /*static void Ex1()
        {
            /*FileInfo fileInfo = new FileInfo(@"C:\Users\ww\Desktop\cafe\cafe.jpg");
            Console.WriteLine(fileInfo.Name);
            Console.WriteLine(fileInfo.FullName);
            Console.WriteLine(fileInfo.Directory);
           
        }*/
        static void g(string s)
        {
            string t=s; 
            char[] array = s.ToCharArray();
           Array.Reverse(array);
            if (new string(array)==t)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    static void Ex2()
        {

            StreamReader sr = new StreamReader("C:/Users/ww/Documents/input.txt");
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
            g(s); 
            sr.Close();
        }

       
           
        
        static void Main(string[] args)
        {
            Ex2();
            Console.ReadKey();
        }
    }
}
 
       