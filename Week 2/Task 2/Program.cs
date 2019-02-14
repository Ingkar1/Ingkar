using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_2
{
    class Program
    {
        public static bool prime(int a)      //boolean function to check is number prime or not(false if not,true if prime)           
        {

            if (a<=1)
            {
            return false;
            }
            for (int i=2;i<=Math.Sqrt(a);i++)
            {
                if(a%i==0)
                {
                    return false;
                }
            }
            return true;    
        }
        
      

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:/Users/ww/Documents/input.txt"); //new reader to read information from given path
            string s = sr.ReadToEnd(); //read all 
            string []s1=s.Split();  //to separate the numbers that splitted by space to array of string 
          
            StreamWriter sw = new StreamWriter("C:/Users/ww/Documents/output.txt"); //new writer that will contain information in given path
           
            for(int i=0;i<s1.Count();i++)  //check array in cycle by using prime boolean function 
            {
            int b=int.Parse(s1[i]);
            if(prime(b)==true)
             {
            sw.Write(b+" "); //to write prime numbers in writer path
             }
            }
         sw.Close(); //to close writer after checking all of numbers 
       
        }
    }
    }

