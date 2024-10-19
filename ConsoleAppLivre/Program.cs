using System;

namespace ConsoleAppLivre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roman roman1 = new Roman("L'Enfant de sable", "Tahar Ben Jelloun", 250, "Fiction", 1985);
            Roman roman2 = new Roman("Les saisons de la solitude", "Ahlam Mosteghanemi", 300, "Fiction", 1993);
            Roman roman3 = new Roman("La mémoire tatouée", "Yasmina Khadra", 320, "Fiction", 2003);
            Console.WriteLine("Détails des romans :");
            roman1.AfficherDetails();
            Console.WriteLine();
            roman2.AfficherDetails();
            Console.WriteLine();
            roman3.AfficherDetails();
            Console.WriteLine();
            Revue revue1 = new Revue("Revue de la littérature marocaine", "Tahar Ben Jelloun", 120, "Littérature", 1, 2023);
            Revue revue2 = new Revue("Les couleurs du Maroc", "Leila Abouzeid", 150, "Culture", 2, 2022);
            Revue revue3 = new Revue("Échos de la culture", "Abdellah Taïa", 100, "Société", 3, 2024);
            Console.WriteLine("Détails des revues :");
            revue1.AfficherDetails();
            Console.WriteLine();
            revue2.AfficherDetails();
            Console.WriteLine();
            revue3.AfficherDetails();
        }
    }
}

