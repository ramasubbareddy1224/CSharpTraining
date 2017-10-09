using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTraining
{
    public class ReadOnlyConstExample : IArrayMethods
    {
        public readonly int loopCount = 5;
        const double PI = 3.12;
        public ReadOnlyConstExample()
        {

        }
        public ReadOnlyConstExample(int count)
        {
            loopCount = count;
        }
        public void DisplayCollectionItems()
        {
            for (int i = 0; i < loopCount; i++)
            {               
                Console.WriteLine(i);
            }
        }
    }
}
