using KsiazkaKonsola;

namespace TestKsiazek
{
    [TestClass]
    public class UnitTest1
    {
        public Ksiazka UtworzenieObiektuKsiazka()
        {
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\dane.txt");
            string[] tablicaStron = daneZPliku.Split(';');

            Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

            for (int i = 1; i < tablicaStron.Length; i++)
            {
                ksiazka.DodajStrone(tablicaStron[i]);
            }
            return ksiazka;
        }

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
        [TestMethod]
        public void PorownanieOstatniejStrony()
        {
            //Arrange
            string daneDoTestowania = "Powrót do miasta nie by³ ju¿ ucieczk¹, lecz wyborem. Ulice wydawa³y siê jaœniejsze, a ludzie mniej obcy. Adam zatrzyma³ siê przy tym samym zegarze, który kiedyœ go niepokoi³. Tym razem uœmiechn¹³ siê, widz¹c jego niedok³adnoœæ. Czas nie by³ wrogiem, lecz towarzyszem. Wiedzia³, ¿e przed nim jeszcze wiele niewiadomych, ale nie ba³ siê ich jak dawniej. Z listem schowanym g³êboko w kieszeni ruszy³ przed siebie, gotów pisaæ dalsz¹ czêœæ w³asnej historii.";
            Ksiazka ksiazka = UtworzenieObiektuKsiazka();
            //Act

            //Assert
            Assert.AreEqual(ksiazka.strony[ksiazka.strony.Count - 1].trescStrony.Trim(), daneDoTestowania.Trim());
        }
        [TestMethod]
        public void PorownywanieCalejStrony()
        {
            //Arrange
            Ksiazka ksiazka = UtworzenieObiektuKsiazka();
            string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\dane.txt");
            string[] tablicaStron = daneZPliku.Split(';');
            //Act

            //Assert
            Assert.AreEqual(ksiazka.strony.Count, tablicaStron.Length);
        }
    }
}