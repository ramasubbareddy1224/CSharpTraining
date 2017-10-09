using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace CSharpTraining
{
   public class StreamWriterExample
    {
        public void WriteContent()
        {
            string path = @"D:\Test.txt";
            using (StreamWriter sw=new StreamWriter(path))
            {
                sw.WriteLine("Hi");
                sw.WriteLine("Hello");
                sw.WriteLine("Pragim Technologies");
                
            }
            Console.WriteLine("File content added to File using StreamWriter in D:\\Test.txt");

            Console.ReadKey();
        }
    }
}
