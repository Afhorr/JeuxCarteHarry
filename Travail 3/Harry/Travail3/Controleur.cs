using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travail3.Repository;

namespace Travail3
{
    class Controleur
    {
        Cartes carteCourante;
        Joueur joueurCourant;
        List<Joueur> lesJoueurs = new List<Joueur>();
        RepositoryCartes leRepositoryCartes;
        RepositoryJoueur leRepositoryJoueur;

        public Joueur JoueurCourant
        {
            get { return joueurCourant; }
        }

        public event EventHandler JoueurInexistant;
        public string JouerCarte()
        {
            carteCourante = leRepositoryCartes.PrendreCarte();
            return carteCourante.RecupererNomCategorie();
        }

        public Controleur()
        {
            carteCourante = null;
            leRepositoryCartes = new RepositoryCartes();
            leRepositoryJoueur = new RepositoryJoueur();
        }

        /*public void ChercherNom(string nom)
        {
            if (lesJoueurs.Count < 4)
            {
                joueurCourant = leRepositoryJoueur.ChercherParNom(nom);
                lesJoueurs.Add(joueurCourant);
                if (joueurCourant.idJoueur == 0)
                {
                    JoueurInexistant(this, new EventArgs());
                }
            }
        }*/

        public string AjouterJoueur(string nomJoueur)
        {
            if (lesJoueurs.Count < 4)
            {
                joueurCourant = leRepositoryJoueur.ChercherParNom(nomJoueur);
                if (joueurCourant.idJoueur == 0)
                {
                    JoueurInexistant(this, new EventArgs());
                }
                lesJoueurs.Add(joueurCourant);
                return joueurCourant.nomJoueur;
            }
            else
            {
                return "full";
            }     
        }

        public int PositionNouveauJoueur()
        {
            return lesJoueurs.Count() - 1;
        }
    }
}
