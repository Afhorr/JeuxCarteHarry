using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Travail3
{
    class repositoryJoueur: iRepositoryJoueur
    {
        MySqlConnection connexion;

        public repositoryJoueur()
        {
            Connexion.BD = "biblio";
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
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }
}
