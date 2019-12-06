using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    class CarteDefense : Cartes
    {
        private int pointsDefense;

        public CarteDefense()
        {
            pointsDefense = 0;
            identifiantCarte = "";
            nomCarte = "";
            antidote = new Antidote();
            categorieCarte = new Categorie();
        }

        public override void AssignerDefense(int defense)
        {
            pointsDefense = defense;
        }

        public override int RecupererDefense()
        {
            Random random = new Random();
            return pointsDefense * random.Next(2, 4);
        }

        public override int RecupererDefenseReduite()
        {
            return pointsDefense / 2;
        }
    }
}
