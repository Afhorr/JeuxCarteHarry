using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    class CarteAttaque : Cartes
    {
        private int pointsMin;
        private int pointsMax;
        static Random random = new Random();

        public CarteAttaque()
        {
            pointsMin = 0;
            pointsMax = 0;
            identifiantCarte = "";
            nomCarte = "";
            antidote = new Antidote();
            categorieCarte = new Categorie();
        }

        public override void AssignerAttaque(int min, int max)
        {
            pointsMin = min;
            pointsMax = max;
        }

        public override int RecupererAttaque()
        {
            return random.Next(pointsMin, pointsMax + 1);
        }
    }
}
