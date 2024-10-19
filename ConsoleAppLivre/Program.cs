
using MonProjet;
internal class Program
{
    static void Main(string[] args)
    {
        Revue revue1 = new Revue("Titre Revue 1", "Auteur 1", 100, 1);
        Revue revue2 = new Revue("Titre Revue 2", "Auteur 2", 150, 2);
        Revue revue3 = new Revue("Titre Revue 3", "Auteur 3", 120, 3);

        revue1.AfficherDetails();
        revue2.AfficherDetails();
        revue3.AfficherDetails();

    }
}