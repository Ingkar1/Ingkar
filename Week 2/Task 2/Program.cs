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
        public static bool prime(int a)               
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
            StreamReader sr = new StreamReader("C:/Users/ww/Documents/input.txt");
            string s = sr.ReadToEnd();
            string []s1=s.Split();
          
            StreamWriter sw = new StreamWriter("C:/Users/ww/Documents/output.txt");
           
            for(int i=0;i<s1.Count();i++)
            {
            int b=int.Parse(s1[i]);
            if(prime(b)==true)
             {
            sw.Write(b+" ");
             }
            }
         sw.Close(); 
       
        }
    }
    }

