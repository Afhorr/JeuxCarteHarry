using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Travail3
{
    class RepositoryJoueur : iRepositoryJoueur
    {
        MySqlConnection connexion;

        public RepositoryJoueur()
        {
            Connexion.BD = "jeuharrypotter";
            Connexion.User = "root";
            Connexion.Password = "";
            connexion = Connexion.getInstance();
        }

        public Joueur ChercherParNom(string nom)
        {
            try
            {
                MySqlCommand commandJoueurNom;
                MySqlDataReader readerJoueurNom;
                Joueur joueur;
                joueur = new Joueur();
                if (connexion != null)
                {
                    commandJoueurNom = connexion.CreateCommand();
                    commandJoueurNom.CommandText = "SELECT * FROM joueurs WHERE prenom='" + nom + "'";
                    readerJoueurNom = commandJoueurNom.ExecuteReader();
                    if (readerJoueurNom.Read())
                    {
                        joueur.idJoueur = Convert.ToInt32(readerJoueurNom["idJoueur"]);
                        joueur.nomJoueur = readerJoueurNom["prenom"].ToString();
                        joueur.pointsJoueur = Convert.ToInt32(readerJoueurNom["pointsJoueur"]); ;
                        joueur.idMaison = Convert.ToInt32(readerJoueurNom["idMaison"]);

                    }
                    readerJoueurNom.Close();
                }
                return joueur;


            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
