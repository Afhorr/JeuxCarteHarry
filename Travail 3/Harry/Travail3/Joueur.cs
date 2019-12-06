using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    class Joueur
    {
        public int idJoueur { get; set; }
        public string nomJoueur { get; set; }
        public int pointsJoueur { get; set; }
        public int idMaison { get; set; }

        public Joueur()
        {
            idJoueur = 0;
            nomJoueur = "";
            pointsJoueur = 0;
            idMaison = 0;
        }

        public void ChangerPoints(int points)
        {
            pointsJoueur += points;
        }
    }
}
