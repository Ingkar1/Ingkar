using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task_1
{
    class FarManager
    {
        public int cursor;
        public int sz;
        bool ok;

        public FarManager()
        {
            cursor = 0;
            ok = true;
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;

        }
        public void Down()
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void Color(FileSystemInfo fs,int index)
        {
            if (index == cursor)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(fs.GetType()==typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

        }
        static void Main(string[] args)
        {
            
        }
    }
}
