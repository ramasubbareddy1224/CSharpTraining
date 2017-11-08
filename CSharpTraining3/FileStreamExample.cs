using System;
using System.IO;
using System.Text;

namespace CSharpTraining3
{
    class FileStreamExample
    {
        public void CallFile()
        {
            FileStream obj = new FileStream("D:\\test.txt", FileMode.Append);
            byte[] bdata = Encoding.Default.GetBytes("Hello This is c# training");
            obj.Write(bdata, 0, bdata.Length);
            obj.Close();
            Console.WriteLine("Successfully saved file with data");

        }
    }
}
