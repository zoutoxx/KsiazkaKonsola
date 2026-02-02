using KsiazkaKonsola;

string daneZPliku = File.ReadAllText(@"C:\Users\Student\Desktop\dane.txt");
string[] tablicaStron = daneZPliku.Split(';');

Ksiazka ksiazka = new Ksiazka(tablicaStron[0]);

for (int i = 1; i < tablicaStron.Length; i++)
{
    ksiazka.DodajStrone(tablicaStron[i]);
}

foreach (Strona str in ksiazka.strony)
{
     if (str.numerStrony == 1)
    {
        Console.WriteLine($"Numer Strony: {str.numerStrony}\nTytuł: {str.trescStrony}");
    }
     else
    {
        Console.WriteLine($"Numer Strony: {str.numerStrony}\nTreść: {str.trescStrony}");
    }
    //Console.WriteLine($"Numer Strony: {str.numerStrony}\nTreść: {str.trescStrony}");
}