using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ConsoleFile
{
    class BufferedStreamClass
    {
        static void Main()
        {
            using (FileStream fs = new FileStream(@"e:\BufferedClass", FileMode.Create, FileAccess.Write))
            {
                using (BufferedStream bs = new BufferedStream(fs))
                {
                    Console.WriteLine($"Length:{bs.Length} \t Position:{bs.Position}");

                    for (int i = 0; i < 64; i++)
                    {
                        bs.WriteByte((byte)i);
                    }
                    Console.WriteLine($"Length:{bs.Length} \t Position:{bs.Position}");
                    byte[] ba = new byte[bs.Length];
                    bs.Position = 0;
                    bs.Read(ba, 0, (int)bs.Length);
                    foreach (byte b in ba)
                    {
                        Console.Write("{0,-3}", b);
                    }
                    Console.WriteLine();
                    string s = "Sakshi";
                    for (int i = 0; i < 3; i++)
                    {
                        bs.WriteByte((byte)s[i]);
                    }
                    Console.WriteLine($"Length:{bs.Length} \t Position:{bs.Position}");

                    for (int i = 0; i < (256 - 67) + 1; i++)
                    {
                        bs.WriteByte((byte)i);
                    }
                    Console.WriteLine($"Length:{bs.Length} \t Position:{bs.Position}");
                }
            }
        }
    }
}
