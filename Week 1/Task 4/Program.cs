using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());  //to change the string type of entered string to int type
             int[,] arr = new int[a, a];   //create a 2D array of integer type
             for (int i = 0; i < a; i++)  
             {
                 for (int j = 0; j < a; j++)  ///cycle to write in Console "[*]"
                 {
                     if (i >= j)
                         Console.Write("[*]");
                 }

                 Console.WriteLine();
             }
             
        }
    }
}
