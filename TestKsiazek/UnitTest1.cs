using KsiazkaKonsola;

namespace TestKsiazek
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestowaniePierwszejStrony()
        {
            //Arrange
            Ksiazka ksiazka = new Ksiazka("Strona 1");
            Strona strona = new Strona("Strona 1");
            //Act

            //Assert
            Assert.AreEqual(ksiazka.strony[0].trescStrony, strona.trescStrony);
            
        }
    }
}