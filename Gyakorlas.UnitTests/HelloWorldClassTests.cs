using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace Gyakorlas.UnitTests
{
    [TestClass]
    public class HelloWorldClassTests
    {
        [TestMethod]
        public void Main_Kiir()
        {
            // Arrange
            string vartEredm = "Helló Világ";

            // Act
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                // HelloWorldClassTests();
            }
        }
    }
}
