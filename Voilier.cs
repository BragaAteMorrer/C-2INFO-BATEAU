using System;
using System.Collections.Generic;

namespace LocationDeBateaux
{
    class Voilier : Boat
    {
        protected override List<string> Inventaire => new List<string> { "Voiles", "Gouvernail", "Ancre", "Mat" };

        private const int CapaciteMaximale = 20;

        public override bool EmbarquerPassagers(int nombrePassagers)
        {
            if (nombrePassagers <= CapaciteMaximale)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Le voilier ne peut pas accueillir plus de {CapaciteMaximale} passagers.");
                return false;
            }
        }
    }
}
