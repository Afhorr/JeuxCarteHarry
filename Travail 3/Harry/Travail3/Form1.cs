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

        List<Label> lesLabelsJoueurs = new List<Label>();

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
            gestionJeu = new Controleur();
            RemplirLabels();
        }

        public void RemplirLabels()
        {
            lesLabelsJoueurs.Add(lbl_Joueur1);
            lesLabelsJoueurs.Add(lbl_Joueur2);
            lesLabelsJoueurs.Add(lbl_Joueur3);
            lesLabelsJoueurs.Add(lbl_Joueur4);
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
            string nomJoueur = gestionJeu.AjouterJoueur(txt_RechercheJoueur.Text);
            if (nomJoueur == "full")
            {
                MessageBox.Show("Il y a déjà 4 joueurs dans cette partie.");
            }
            else if (nomJoueur != "")
            {

                int positionJoueur = gestionJeu.PositionNouveauJoueur();
                AfficherJoueur(positionJoueur, nomJoueur);
            }
        }

        private void Btn_JouerCarte_Click(object sender, EventArgs e)
        {
            MessageBox.Show(gestionJeu.JouerCarte());
        }

        public void AfficherJoueur(int positionJoueur, string nomJoueur)
        {
            lesLabelsJoueurs[positionJoueur].Text = nomJoueur;
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
