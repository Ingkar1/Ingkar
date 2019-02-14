using System;
using System.IO;

namespace Ex1
{
    class FarManager //new class of FarManager
    {
        public int cursor;     
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager() 
        {
            cursor = 0;
        }

        public FarManager(string path) //the Path class which performs operations 
                                       //on String instances that contain file or directory path information
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index,int i) //function to show a color
        {
            if (cursor == index && cursor==i)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()  //create a function to show a files
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos(); 
           
            for (int i = 0, k = 0; i < fs.Length; i++)  //thic cycle helps to avoid from reading a files that start with "."
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
             
                
                    
                Color(fs[i], k,i);
                Console.Write(i+1+". ");
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }
        public void Up() //cursor up
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down() //cursor down
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }
        public void Opentxt(string path) //to open text file
            {
            Console.Clear();
            StreamReader sr=new StreamReader(path); //new reader for reading text files
            string s=sr.ReadToEnd();  //read all
            Console.WriteLine(s);  //write in console
            ConsoleKeyInfo k1=Console.ReadKey(); 
            if(k1.Key==ConsoleKey.Backspace) //in order to exit from directory or file
                {
                sr.Close();
                return;
            }
            else
            Opentxt(path);
            }
        public void CalcSz()  //this function does not show a files that start with '.'
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)  //condition
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)  
                    Up();  //call Up function
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down(); //call Down function 
              
                if (consoleKey.Key == ConsoleKey.Enter) //to open current directory
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                    else if(currentFs.Name.EndsWith(".txt")) //if you press Enter key to text file,Opentxt function will be called and text file will be opened
                        Opentxt(currentFs.FullName);
                    
                }
                if (consoleKey.Key == ConsoleKey.Backspace) //to go backward 
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if(consoleKey.Key==ConsoleKey.Delete) //to delete file or directory where cursor is
                {           
                           cursor=0;
                     if(currentFs.GetType()==typeof(DirectoryInfo))
                     Directory.Delete(currentFs.FullName, true); 
                           currentFs.Delete();
                }
                if(consoleKey.Key==ConsoleKey.N)  // to rename the files or directories
                    {
                    string a=Console.ReadLine();
                    a=Path.Combine(directory.FullName,a);
                    if(currentFs.GetType()== typeof(DirectoryInfo))
                        Directory.Move(currentFs.FullName,a);
                    else
                        File.Move(currentFs.FullName,a); //Move function
                    }

                
                }
            }


    }


    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/History";
            FarManager farManager = new FarManager(path); //create new far manager
            farManager.Start(); //call function Start()
        }
    }
}
