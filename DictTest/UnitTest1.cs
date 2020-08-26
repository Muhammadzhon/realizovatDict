using DictLibrary;
using System;
using System.Collections.Generic;
using System.Security;
using Xunit;

namespace DictTest
{
    public class DictTestCheck
    {
        private object cites;

        [Fact]
        public void CheckAdding()
        {            
            var expected = 1;

            var goroda = new DictLibCheck();
            goroda.Add(1, "Djal");
            var actual = goroda.Length();

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckValue()
        {
            var expected = "Tal";

            var goroda = new DictLibCheck();
            goroda.Add(1, "Bish");
            goroda.Add(2, "Osh");
            goroda.Add(3, "Djal");
            goroda.Add(4, "Iss");
            goroda.Add(5, "Nar");
            goroda.Add(6, "Bat");
            goroda.Add(7, "Tal");

            var actual = goroda.GetValue(7);

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void CheckRemoving()
        {
            var expected = 1;

            var goroda = new DictLibCheck();
            goroda.Add(1, "Bish");
            goroda.Add(2, "Osh");
            goroda.Remove(2);

            var actual = goroda.Length();

            Assert.Equal(expected, actual);
        }


    }
}
