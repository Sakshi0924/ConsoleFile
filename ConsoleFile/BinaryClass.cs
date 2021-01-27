using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFile
{
    class BinaryClass
    {
        static void Main()
        {
            using (FileStream fs = new FileStream(@"e:\Binaryfile", FileMode.Create, FileAccess.Write))
            {      //StreamWriter is more for text and BinaryWriter is for primitive types
                   //including strings of particular encodings.
                using (BinaryWriter bw = new BinaryWriter(fs))
                {
                    bw.Write(true);    //boolean
                    bw.Write('x');     //char
                    bw.Write(1.205F);    //Float
                    bw.Write("Hello EveryOne");          //string
                    bw.Write("This is Binary Class");        //string
                    
                }
            }

            using (FileStream fs2 = new FileStream(@"e:\Binaryfile", FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs2))
                {

                    Console.WriteLine("Boolean Value:"+br.ReadBoolean());
                    Console.WriteLine("Character Value:"+br.ReadChar());
                    Console.WriteLine("Float Value:"+br.ReadSingle());
                    Console.WriteLine("String :"+br.ReadString());
                    Console.WriteLine("String :"+br.ReadString());
                    
                }
            }



        }
    }
}
