using System;




public class Roman : Livre
{
    public int AnneePublication { get; set; 
    public Roman(string titre, string auteur, int nombreDePages, string genre, int anneePublication)
        : base(titre, auteur, nombreDePages, genre) e
    {
        AnneePublication = anneePublication;
    }

   
    public override void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine($"Année de Publication: {AnneePublication}");
    }
}
}
