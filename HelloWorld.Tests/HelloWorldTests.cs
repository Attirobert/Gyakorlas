using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldClassTest
    {
        [TestMethod]
        public void TestKiir()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            string vartEredm = "Hello World!";

            // Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                var kapottEredm = sw.ToString().Trim();

                // Assert: Kiértékelés
                Assert.AreEqual(vartEredm, kapottEredm);
            }
        }
    }
}
