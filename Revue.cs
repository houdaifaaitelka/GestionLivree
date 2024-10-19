using Systeme
 public class Revue : Livre
{
    public int Numero { get; set; }
    public int Annee { get; set; }

    public Revue(string titre, string auteur, int nombreDePages, string genre, int numero, int annee)
        : base(titre, auteur, nombreDePages, genre)
    {
        Numero = numero;
        Annee = annee;
    }

    public override void AfficherDetails()
    {
        base.AfficherDetails();
        Console.WriteLine($"Numéro de la revue: {Numero}");
        Console.WriteLine($"Année de publication: {Annee}");
    } }
