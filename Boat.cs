using System;
using System.Collections.Generic;

namespace LocationDeBateaux
{
    abstract class Boat
    {
        protected abstract List<string> Inventaire { get; }

        public abstract bool EmbarquerPassagers(int nombrePassagers);

        public void VerifierInventaire()
        {
            Console.WriteLine("Vérification de l'inventaire :");
            foreach (var item in Inventaire)
            {
                Console.WriteLine("- " + item);
            }
        }
    }
}
