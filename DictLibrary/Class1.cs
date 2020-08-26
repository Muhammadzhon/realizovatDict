using System;
using System.Collections.Generic;
using System.Data;

namespace DictLibrary
{
    public class DictLibCheck
    {
        
        Dictionary<int, string> cites = new Dictionary<int, string>(7);

        public int Length() => cites.Count;
        public void Add(int key, string value)
        {
            try
            {
                cites.Add(key, value);

            }
            catch (ArgumentException)
            {
                Console.WriteLine($"{key} уже существует в списке!");
            }          

        }


        public string GetValue(int key)
        {
            return cites.TryGetValue(key, out string value) ? value : "не существует";
        }

        public void Remove(int key)
        {
            try
            {
                cites.Remove(key);

            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"{key} не найден в списке!");
            }
        }

        public void Print()
        {
            foreach (KeyValuePair<int, string> pair in cites)
            {
                Console.WriteLine($"{pair.Key} | {pair.Value}");
            }

        }

        public static Dictionary<int, string> Filter(Func<int, string, int> predicate)
        {
            var stayed = 

            return 
        }

        
        


        


}
}
