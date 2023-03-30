using NegyzetTDD;

namespace NegyzetTDDTests
{
    [TestClass]
    public class NegyzetTests
    {
        [TestMethod]
        public void KeruletTest()
        {
            // Arrange
            int oldal = 10; 
            Negyzet negyzet = new Negyzet(oldal);
            int vartEredm = 100;

            // Act
            int kapottEredm = negyzet.getKerulet();

            // Assert
            Assert.AreEqual(vartEredm, kapottEredm);
        }
    }
}