using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
   public class StreamReaderExample
    {
        public void ReadContent()
        {
            string path = "D:\\Test.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
            Console.WriteLine("Reading Completed");
            Console.ReadKey();
        }
    }
}
