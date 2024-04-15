using System;

namespace LocationDeBateaux
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue chez Santiano Location ! Notre service de location de bateaux");
            Console.WriteLine("Veuillez choisir le type de bateau (1 pour bateau à voile, 2 pour bateau à moteur) :");
            int choixBateau = Convert.ToInt32(Console.ReadLine());

            Boat bateau;

            if (choixBateau == 1)
            {
                bateau = new Voilier();
            }
            else if (choixBateau == 2)
            {
                bateau = new BateauMoteur();
            }
            else
            {
                Console.WriteLine("Choix invalide. Veuillez choisir 1 ou 2.");
                return;
            }

            Console.WriteLine("Combien de passagers embarqueront ?");
            int nombrePassagers = Convert.ToInt32(Console.ReadLine());

            if (!bateau.EmbarquerPassagers(nombrePassagers))
            {
                Console.WriteLine("Le nombre de passagers est trop élevé pour ce bateau.");
                return;
            }

            Console.WriteLine("Les passagers ont été enregistrés.");

            Console.WriteLine("Le bateau est de retour.");
            bateau.VerifierInventaire();

            Console.WriteLine("Il est temps de se reposer.");
        }
    }
}
