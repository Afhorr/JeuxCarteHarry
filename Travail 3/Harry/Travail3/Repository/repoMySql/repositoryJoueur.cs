using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Travail3
{
    class repositoryJoueur : iRepositoryJoueur
    {
        MySqlConnection connexion;

        public repositoryJoueur()
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
                    commandJoueurNom.CommandText = "Select * from titles where Pubid='" + nom + "'";
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
