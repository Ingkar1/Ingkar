using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string[] s2 = Console.ReadLine().Split();
            int a = int.Parse(s1);
            string t="";
            int count1=0;
            for (int i = 0; i < a; i++)
            {
                int b = int.Parse(s2[i]);
                int count = 0;
               
                for(int j = 2; j <= Math.Sqrt(b); j++)
                {
                    if (b % j == 0)
                        count++;
                  
                }
                if(count==0 && b!=1)
                    {
                    t+=s2[i]+" ";
                   count1++;
                    }                  
                   
                     

            }
                    Console.WriteLine(count1);
                    Console.Write(t);
        }
    }
}
