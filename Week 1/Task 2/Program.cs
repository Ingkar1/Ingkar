﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student 
{
        private string name;
        private string id;
        public int yearofstudy;
         
        public Student( string name, string id)
        {
            
            this.name = name;
            this.id = id;
            
        }
        public void inc()
        {
            yearofstudy++;
        }
        
          public int Yearofstudy
            {
            get
            {
                return yearofstudy;
            }
            set
            {
                yearofstudy=value;
            }
            

       
}
        
          /*public override string ToString()
            {
            return name+" "+id+" "+yearofstudy;
            }*/
}
        

    class Program
    {
        static void Main(string[] args)
        {
               Student st1 = new Student("Ingkar", "18BD01027");
               st1.yearofstudy=2018;
               st1.inc();
            Console.WriteLine(st1.yearofstudy);
            Console.ReadKey();
        }
    }
}
