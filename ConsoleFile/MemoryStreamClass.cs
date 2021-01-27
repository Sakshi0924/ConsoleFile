using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleFile
{
    class MemoryStreamClass
    {
        static void Main()
        {
            UnicodeEncoding uniEncoding = new UnicodeEncoding();
            byte[] firstString = uniEncoding.GetBytes("Hello ");
            MemoryStream ms = new MemoryStream();
            ms.Write(firstString, 0, firstString.Length);

            Console.WriteLine($"Capacity :{ ms.Capacity.ToString()}");
            Console.WriteLine("Length :" +ms.Length.ToString());
            Console.WriteLine("Position:"+ms.Position.ToString());
            ms.Seek(0, SeekOrigin.Begin);

            Console.WriteLine( ms.Read(firstString, 0, firstString.Length));
        }
    }
}
