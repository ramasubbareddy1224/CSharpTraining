using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining3
{
    class StreamReaderExample
    {
        public void ReadData()
        {
            using (StreamReader reader = new StreamReader("D:\\test.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());                
            }

            //StreamReader reader1 = new StreamReader("D:\\test.txt");
            //Console.WriteLine(reader1.ReadToEnd());
            //reader1.Close();



        }
    }
}
