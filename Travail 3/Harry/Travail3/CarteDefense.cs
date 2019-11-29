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
            return pointsDefense;
        }
    }
}
