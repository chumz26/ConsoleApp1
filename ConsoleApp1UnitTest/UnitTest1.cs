using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleApp1UnitTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            string[] args = new string[] { "test" }; 

            ConsoleApp1.Program.Main(args);
        }
    }
}
