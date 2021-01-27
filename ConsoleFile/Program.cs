using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = null;
            string data = null;
            Console.WriteLine("enter the text: ");
            while (str != "#")
            {                
                str = Console.ReadLine();

                if (str != "#")
                {
                    data = data + str;
                }
            }

            
            using (FileStream fs = new FileStream(@"e:\files.txt", FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                   
                    sw.WriteLine(data);
                }

            }
            using (FileStream fs2 = new FileStream(@"e:\files.txt", FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs2))
                {
                    Console.WriteLine($"reading contents of files.txt:{ sr.ReadToEnd()}");
                }

            }

            string data1;
            Console.WriteLine("Enter the text:");
            data1 = Console.ReadLine();
            File.WriteAllText("static.txt", data1);
            Console.WriteLine("Contents of the file: " + File.ReadAllText("static.txt"));
            File.AppendAllText("static.txt", " How are you all? ");

        }
    }
}
