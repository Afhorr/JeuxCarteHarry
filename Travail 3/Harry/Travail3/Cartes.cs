using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    abstract class Cartes
    {
        protected string identifiantCarte;
        protected string nomCarte;
        protected Antidote antidote;
        protected Categorie categorieCarte;

        public Cartes()
        {
            identifiantCarte = "";
            nomCarte = "";
            antidote = new Antidote();
            categorieCarte = new Categorie();
        }

        public void AssignerCategorie(Categorie categorie)
        {
            categorieCarte = categorie;
        }

        public string RecupererNomCategorie()
        {
            return categorieCarte.RecupererNom();
        }

        public void AssignerValeurAntidote(string nom, int valeur)
        {
            antidote.AssignerValeur(nom, valeur);
        }

        public int RecupererValeurAntidote()
        {
            return antidote.RecupererValeur();
        }

        public virtual void AssignerAttaque(int min, int max)
        {

        }

        public virtual void AssignerDefense(int defense)
        {

        }

        public virtual int RecupererAttaque()
        {
            return 0;
        }

        public virtual int RecupererDefense()
        {
            return 0;
        }
    }
}
