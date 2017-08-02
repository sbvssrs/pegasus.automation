using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace PegasusAutomationTestScripts.Pegasus_Test_Steps
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(ConfigurationManager.AppSettings["Browser"]);
        }
    }
}
