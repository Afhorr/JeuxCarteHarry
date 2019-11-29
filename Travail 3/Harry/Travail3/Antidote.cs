using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    class Antidote
    {
        private string nomAntidote;
        private int pointsAntidote;

        public Antidote()
        {
            nomAntidote = "";
            pointsAntidote = 0;
        }
        public void AssignerValeur(string nom, int valeur)
        {
            nomAntidote = nom;
            pointsAntidote = valeur;
        }

        public int RecupererValeur()
        {
            return pointsAntidote;
        }
    }
}
