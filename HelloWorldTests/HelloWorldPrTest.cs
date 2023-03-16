using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldPrTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string vartEredm = "Hello World!",
                kapottEredm = string.Empty;

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                HelloWorld.HelloWorldPr.Main();
                kapottEredm = sw.ToString().Trim();
            }

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }
    }
}
