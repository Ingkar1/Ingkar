using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
         class Student //new class of Student
          {
        private string name;
        private string id;
        private int yearofstudy;
         
        public Student( string name, string id)//provide information about student's name and id
        {
            
            this.name = name;
            this.id = id;
            
        }
        public void inc()  //function to increment the value of yearofstudy
        {
            yearofstudy++;
        }
        
          public int Yearofstudy //methods of getting information about student
            {
            get  //returns the property value or the indexer element(yearofstudy)
            {
                return yearofstudy;
            }
            set  //assigns a value to the property or the indexer element(yearofstudy)
            {
                yearofstudy=value;
            }
            
        }
       

        static void Main(string[] args)
        {
               Student st1 = new Student("Ingkar", "18BD01027");
               st1.yearofstudy=2018;
               st1.inc();//function to increment the value of yearofstudy of st1
            Console.WriteLine(st1.yearofstudy);//write in Console the incremented value of yearofstudy
            Console.ReadKey();
        }
  
  
       }


}
    }