using System;
using System.Collections.Generic;

namespace LocationDeBateaux
{
    class BateauMoteur : Boat
    {
        protected override List<string> Inventaire => new List<string> { "Moteur", "Safran", "Ancre", "Réservoir" };

        private const int CapaciteMaximale = 35;

        public override bool EmbarquerPassagers(int nombrePassagers)
        {
            if (nombrePassagers <= CapaciteMaximale)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Le bateau à moteur ne peut pas accueillir plus de {CapaciteMaximale} passagers.");
                return false;
            }
        }
    }
}
