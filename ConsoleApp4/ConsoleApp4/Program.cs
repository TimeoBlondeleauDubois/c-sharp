using System;

class Livre
{
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int NombreDePages { get; set; }
    public string Editeur { get; set; }

    public Livre(string titre, string auteur, int nombreDePages, string editeur)
    {
        Titre = titre;
        Auteur = auteur;
        NombreDePages = nombreDePages;
        Editeur = editeur;
    }
}

class Program
{
    static void Main()
    {
        Livre livre1 = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", 1200, "Christian Bourgois");
        Livre livre2 = new Livre("Harry Potter", "J.K. Rowling", 800, "Gallimard");

        Console.WriteLine($"Le livre {livre1.Titre} a été écrit par {livre1.Auteur} et contient {livre1.NombreDePages} pages.");
        Console.WriteLine($"Le livre {livre2.Titre} a été écrit par {livre2.Auteur} et contient {livre2.NombreDePages} pages.");
    }
}
