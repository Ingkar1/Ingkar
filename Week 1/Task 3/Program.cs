using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = int.Parse(Console.ReadLine());
            string[] arr = Console.ReadLine().Split(' ');
            */
            string s=Console.ReadLine(); //enter first line(number)
            int a = int.Parse(s);  //change string type to integer type
            
                string[] s1 = Console.ReadLine().Split(); //separate the elements of entered array
              
          
            
            
            for (int i = 0; i < a; i++) //run through the elements of array
            {
                  int b = int.Parse(s1[i]); //change the type of elements(string) to integer type

                for(int j = 0; j < 2; j++) //create a new integer j to run through the elements of array and repeat them twice
                {
                    Console.Write(b + " ");//show the repeated elements of array
                }





            }
      
        }
    }
}
