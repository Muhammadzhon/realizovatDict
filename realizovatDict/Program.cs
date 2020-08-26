using DictLibrary;
using System;
using System.Collections.Generic;

namespace realizovatDict
{
    class Program
    {
        static void Main(string[] args)
        {
            var actual = new DictLibCheck();
            actual.Add(3, "Djal");
            actual.Add(3, "Tal");
        }
    }
}
