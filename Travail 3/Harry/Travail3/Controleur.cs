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
        int indexJoueurCourant = 0;
        List<Joueur> lesJoueurs = new List<Joueur>();
        RepositoryCartes leRepositoryCartes;
        RepositoryJoueur leRepositoryJoueur;

        public Joueur JoueurCourant
        {
            get { return joueurCourant; }
        }

        public event EventHandler JoueurInexistant;
        public void JouerCarte()
        {
            carteCourante = leRepositoryCartes.PrendreCarte();
        }

        public string NomCarteCourante()
        {
            return carteCourante.RecupererNomCarte();
        }

        public int AttaqueCarteCourante()
        {
            return carteCourante.RecupererAttaque();
        }

        public int DefenseCarteCourante()
        {
            return carteCourante.RecupererDefense();
        }

        public string TypeCarteCourante()
        {
            if(carteCourante.RecupererAttaque() == 0)
            {
                return "Defense";
            }
            else
            {
                return "Attaque";
            }
        }

        public string NomAntidoteCarteCourante()
        {
            return carteCourante.RecupererNomAntidote();
        }

        public int ValeurAntidoteCarteCourante()
        {
            return carteCourante.RecupererValeurAntidote();
        }

        public string CategorieCarteCourante()
        {
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
        public int ObtenirJoueurCourant()
        {
            return indexJoueurCourant;
        }

        public void DebutJeu()
        {
            joueurCourant = lesJoueurs[indexJoueurCourant];
        }

        public void ChangerDeTour()
        {
            indexJoueurCourant = ((indexJoueurCourant + 1) % 4);
            joueurCourant = lesJoueurs[indexJoueurCourant];
        }

        public int RecupererPointsJoueur(int positionJoueur)
        {
            return lesJoueurs[positionJoueur].pointsJoueur;
        }
    }
}
