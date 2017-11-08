using System;
using System.Collections.Generic;
using System.Collections;


namespace CSharpTraining3
{
    class DictionaryExample
    {
        public void PrintData()
        {
            Dictionary<string, string> dicList = new Dictionary<string, string>();
            dicList.Add("rama", "XXCCAD");
            dicList.Add("siva", "BAXAA");
            dicList.Add("krishna", "@#ZZ");

            foreach (var item in dicList)
            {
                Console.WriteLine(item.Key +" "+ item.Value);
            }

            Hashtable htList = new Hashtable();
            htList.Add("rama", "XXCCAD");
            htList.Add("siva", 123);
            htList.Add("krishan", "abc");
        }

        //public string GetValueFromKey(string key)
        //{

        //}
    }
}
