using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student 
{
        public string name;
        public string id;
        public int yearofstudy;
        
        public void inc()
        {
            yearofstudy++;
        }

        public Student( string name, string id,int yearofstudy)
        {
            
            this.name = name;
            this.id = id;
            this.yearofstudy = yearofstudy;
        }
   
        
          public override string ToString()
            {
            return name+" "+id+" "+yearofstudy;
            }
}
        

    class Program
    {
        static void Main(string[] args)
        {
               Student st1 = new Student("aaa", "18BD01027", 2018);
             Console.WriteLine(st1);
            Console.ReadKey();
        }
    }
}
