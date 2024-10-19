using System;

public class Livre
{
    public string Titre { get; set; }
    public string Auteur { get; set; }
    public int NombreDePages { get; set; }
    public string Genre { get; set; }  
    public Livre(string titre, string auteur, int nombreDePages, string genre)
    {
        Titre = titre;
        Auteur = auteur;
        NombreDePages = nombreDePages;
        Genre = genre;
    }

    public virtual void AfficherDetails()
    {
        Console.WriteLine($"Titre: {Titre}");
        Console.WriteLine($"Auteur: {Auteur}");
        Console.WriteLine($"Nombre de pages: {NombreDePages}");
        Console.WriteLine($"Genre: {Genre}"); 
    }
}
}
