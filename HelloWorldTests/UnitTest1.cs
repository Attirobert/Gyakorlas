

namespace HelloWorldTests
{
    [TestClass]
    public class HelloWorldTests
    {
        [TestMethod]
        public void MainKiirOK()
        {
            // Arrange: Beállítások és a várt eredmény megadása
            string vartEredm = "Helló Világ!";

            // Act: Tesztelt metódus meghívása
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                

            }
        }
    }
}