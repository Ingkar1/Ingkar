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
            string s1 = Console.ReadLine(); //input the number in first line
            string[] s2 = Console.ReadLine().Split(); //separate a string by array of string 
            int a = int.Parse(s1); //change the string type of first line to integer type
            string t=""; //create a new empty string to save prime numbers
            int count1=0; //counter of whole prime numbers
            for (int i = 0; i < a; i++)  //create a cycle that runs through numbers of array
            {
                int b = int.Parse(s2[i]); //change the string type of numbers in array to integer type
                int count = 0; //new integer to count and refresh the own mean to 0 for each new i
               
                for(int j = 2; j <= Math.Sqrt(b); j++) //creat a cycle that run from 2 to mean sqrt of integers in array
                {
                    if (b % j == 0) // ------
                        count++; //to find all divisors of b by this condition
                  
                }
                if(count==0 && b!=1)//condition of checking prime or not
                    {
                    t+=s2[i]+" "; //to add a prime numbers to string t if condition is true
                   count1++; //count the whole prime numbers
                    }                  
                   
                     

            }
                    Console.WriteLine(count1); //output the counter 
                    Console.Write(t); //output prime numbers
        }
    }
}
