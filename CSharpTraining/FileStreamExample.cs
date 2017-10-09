using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharpTraining
{
    public class FileStreamExample
    {
        public void ExecuteFile()
        {

            FileStream fsObj = null;
            try
            {
                string path = @"D:\Test.txt";
                fsObj = new FileStream(path, FileMode.Append,FileAccess.Write);
                byte[] bdata = Encoding.Default.GetBytes("Hello Pragim!");
                fsObj.Write(bdata, 0, bdata.Length);

                Console.WriteLine("File has been created under D:\\Test.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file is already Exist");
                Console.WriteLine("Exception Message:"+ex.Message);
            }
            finally
            {
                if (fsObj != null)
                {
                    fsObj.Close();
                }

            }
            Console.ReadKey();
        }
    }
}