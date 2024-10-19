using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleAppLivre
{
    public class Roman : Livre 
    {
        public int AnneePublication { get; set; }
        public Roman(string titre, string auteur, int nombreDePages, string genre, int anneePublication)
            : base(titre, auteur, nombreDePages, genre) 
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
