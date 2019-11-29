using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail3
{
    public partial class Form1 : Form
    {
        Controleur gestionJeu;
        public Form1()
        {

            InitializeComponent();
            try
            {
                gestionJeu = new Controleur();
                AbonnerEvenementControleur();
            }
            catch (Exception)
            {

                MessageBox.Show("le serveur est fermé");
            }
        }

        void AbonnerEvenementControleur()
        {
            gestionJeu.JoueurInexistant += gestion_JoueurNonTrouve;
        }
        private void gestion_JoueurNonTrouve(object sender,EventArgs e)
        {
            MessageBox.Show("Joueur inexistant");
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_RechercheJoueur_Click(object sender, EventArgs e)
        {
            try
            {
                gestionJoueur.ChercherNom(txt_RechercheJoueur);
                afficherJoueur();
            }
            catch (FormatException)
            {

                MessageBox.Show("Entrez un nom valide");
            }
        }
        void afficherJoueur()
        {
            ViderLabel();
            Joueur JoueurCourant;
            JoueurCourant = gestionJoueur.JoueurCourant;

            for (int LeJoueurCourant = 0; LeJoueurCourant < 4; LeJoueurCourant++)
            {
                switch (LeJoueurCourant)
                {
                    case 0:
                        lbl_Joueur1.Text = "Nom: " + JoueurCourant.nomJoueur + "Points: " + JoueurCourant.pointsJoueur.ToString();
                        break;
                    case 1:
                        lbl_Joueur2.Text = "Nom: " + JoueurCourant.nomJoueur + "Points: " + JoueurCourant.pointsJoueur.ToString();
                        break;
                    case 2:
                        lbl_Joueur3.Text = "Nom: " + JoueurCourant.nomJoueur + "Points: " + JoueurCourant.pointsJoueur.ToString();
                        break;
                    case 3:
                        lbl_Joueur4.Text = "Nom: " + JoueurCourant.nomJoueur + "Points: " + JoueurCourant.pointsJoueur.ToString();
                        break;
                }
            } 

            
        }
        void ViderLabel()
        {
            lbl_Joueur1.Text = "";
            lbl_Joueur2.Text = "";
            lbl_Joueur3.Text = "";
            lbl_Joueur4.Text = "";
        }
    }
}
