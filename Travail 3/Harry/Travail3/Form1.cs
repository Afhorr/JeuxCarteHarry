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
        List<Label> lesLabelsPoints = new List<Label>();
        List<Button> lesBouttonsAttaque = new List<Button>();

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
            RemplirListes();
            AfficherJoueurCourant();
        }

        public void RemplirListes()
        {
            lesLabelsJoueurs.Add(lbl_Joueur1);
            lesLabelsJoueurs.Add(lbl_Joueur2);
            lesLabelsJoueurs.Add(lbl_Joueur3);
            lesLabelsJoueurs.Add(lbl_Joueur4);

            //lesLabelsPoints.Add(lbl_pointsJoueur1);
            //lesLabelsPoints.Add(lbl_pointsJoueur2);
            //lesLabelsPoints.Add(lbl_pointsJoueur3);
            //esLabelsPoints.Add(lbl_pointsJoueur4);

            lesBouttonsAttaque.Add(btn_Joueur1);
            lesBouttonsAttaque.Add(btn_Joueur2);
            lesBouttonsAttaque.Add(btn_Joueur3);
            lesBouttonsAttaque.Add(btn_Joueur4);
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
                int pointsJoueur = gestionJeu.RecupererPointsJoueur(positionJoueur);
                AfficherJoueur(positionJoueur, nomJoueur, pointsJoueur);
            }
            SetupPlayer();
        }

        private void Btn_JouerCarte_Click(object sender, EventArgs e)
        {
            gestionJeu.JouerCarte();
            AfficherInfoCarte();
            gestionJeu.ChangerDeTour();
            AfficherJoueurCourant();
        }

        public void AfficherInfoCarte()
        {
            lbl_NomCarte.Text = "Nom: " + gestionJeu.NomCarteCourante();
            lbl_CategorieCarte.Text = "Categorie: " + gestionJeu.CategorieCarteCourante();
            lbl_AttaqueCarte.Text = "Points d'attaque: " + gestionJeu.AttaqueCarteCourante();
            lbl_DefenseCarte.Text = "Points de défense: " + gestionJeu.DefenseCarteCourante();
            lbl_TypeCarte.Text = "Type: " + gestionJeu.TypeCarteCourante();
            lbl_NomAntidote.Text = "Nom antidote: " + gestionJeu.NomAntidoteCarteCourante();
            lbl_ValeurAntidote.Text = "Valeur antidote: " + gestionJeu.ValeurAntidoteCarteCourante();
            
        }

        public void AfficherJoueur(int positionJoueur, string nomJoueur, int pointsJoueur)
        {
            lesLabelsJoueurs[positionJoueur].Text = "Nom: " + nomJoueur;
            lesLabelsPoints[positionJoueur].Text = "Points: " + pointsJoueur.ToString();
        }

        public void AfficherJoueurCourant()
        {
            lbl_Joueur1.BackColor = Control.DefaultBackColor;
            lbl_Joueur2.BackColor = Control.DefaultBackColor;
            lbl_Joueur3.BackColor = Control.DefaultBackColor;
            lbl_Joueur4.BackColor = Control.DefaultBackColor;

            lesLabelsJoueurs[gestionJeu.ObtenirJoueurCourant()].BackColor = Color.Red;
            EnableButtons();
            lesBouttonsAttaque[gestionJeu.ObtenirJoueurCourant()].Enabled = false;
            
        }

        private void EnableButtons()
        {
            for (int i = 0; i < 4; i++)
            {
                lesBouttonsAttaque[i].Enabled = true;
            }
        }

        public void SetupPlayer()
        {
            if (lesLabelsJoueurs[3].Text != "")
            {
                btn_JouerCarte.Enabled = true;
            }
        }

        void ViderLabel()
        {
            lbl_Joueur1.Text = "";
            lbl_Joueur2.Text = "";
            lbl_Joueur3.Text = "";
            lbl_Joueur4.Text = "";
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Joueur1_Click(object sender, EventArgs e)
        {
            JouerCarte(1);
        }


        private void JouerCarte(int indexCible)
        {
            gestionJeu.JouerCarte();
            AfficherInfoCarte();
            InfligerDegats(indexCible);
            gestionJeu.ChangerDeTour();
            AfficherJoueurCourant();
        }

        private void InfligerDegats(int indexCible)
        {
            if (gestionJeu.TypeCarteCourante() == "Attaque")
            {
                gestionJeu.InfligerDegats(indexCible);
                gestionJeu.UtiliserAntidote(indexCible);
            }
            else
            {
                gestionJeu.ProtegerJoueur();
                gestionJeu.AffaiblirAdverse(indexCible);
                gestionJeu.UtiliserAntidote(indexCible);
            }
        }

        private void Btn_Joueur2_Click(object sender, EventArgs e)
        {
            JouerCarte(2);
        }

        private void Btn_Joueur3_Click(object sender, EventArgs e)
        {
            JouerCarte(3);
        }

        private void Btn_Joueur4_Click(object sender, EventArgs e)
        {
            JouerCarte(4);
        }
    }
}
