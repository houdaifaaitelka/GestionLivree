using System;
namespace MonProjet
{
    public class Revue : Livre
    {
        public int Numero { get; set; }
        public int Annee { get; set; }
        public Revue(string titre, string auteur, int nombreDePages, int numero, int annee)
            : base(titre, auteur, nombreDePages)
        {
            Numero = numero;
            Annee = annee;
        }
        public override void AfficherDetails()
        {
            base.AfficherDetails();
            Console.WriteLine($"Numéro de la revue: {Numero}");
            Console.WriteLine($"Année de publication: {Annee}");
        }

    }
}
