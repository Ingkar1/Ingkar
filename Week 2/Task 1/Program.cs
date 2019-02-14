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
            string t=s;  //firstly we take a string t that equal to s
            char[] array = s.ToCharArray();    //to separate and put chars of s string to array of chars
           Array.Reverse(array);    //function to reverse 
            if (new string(array)==t) //condition of checking equality of reversed array to string t
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    static void Ex2()
        {

            StreamReader sr = new StreamReader("C:/Users/ww/Documents/input.txt"); //create reader to read information  from given path
            string s = sr.ReadToEnd();  //read all
            Console.WriteLine(s); //write in Console all information as string s
            g(s); //function of checking polyndrome
            sr.Close(); //after reading and writing in Console we close the reader
        }

       
           
        
        static void Main(string[] args)
        {
            Ex2(); //funcion 
            Console.ReadKey();
        }
    }
}
 
       