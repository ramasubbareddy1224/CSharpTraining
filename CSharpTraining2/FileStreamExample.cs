using System;
using System.IO;
using System.Text;

namespace CSharpTraining2
{
    class FileStreamExample
    {
        public void Execute()
        {
            FileStream fs = new FileStream("D:\\test.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Hello File Handling!");
            fs.Write(bdata, 0, bdata.Length);
            fs.Close();
            Console.WriteLine("Successfully saved file with data : Hello File Handling!");

        }
    }
}
