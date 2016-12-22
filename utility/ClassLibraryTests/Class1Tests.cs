using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void unitTestTest()
        {
            Class1 c = new Class1();
            int b = c.unitTest();
            Assert.IsTrue(b==1010);
        }
    }
}