using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Travail3.Repository
{
    class repositoryCartes: iRepositoryCartes
    {
        MySqlConnection connexion;

        public repositoryCartes()
        {
            Connexion.BD = "jeuharrypotter";
            Connexion.User = "root";
            Connexion.Password = "";
            //impossible de faire un new
            connexion = Connexion.getInstance();
        }

        public Cartes PrendreCarte()
        {
            MySqlCommand commandCarte;
            MySqlDataReader readerCarte;
            Cartes carte = new CarteAttaque();
            Categorie categorie = new Categorie();
            if (connexion != null)
            {
                commandCarte = connexion.CreateCommand();
                commandCarte.CommandText = "SELECT identifiant, nomCarte, pointsMin, pointsMax, pointsDefense, nomAntidote, pointsAntidote, CategorieCarte, nomCategorie " +
                                           "FROM cartes " +
                                           "INNER JOIN categories ON categories.idCategorie = cartes.CategorieCarte " +
                                           "ORDER BY RAND() LIMIT 1";
                readerCarte = commandCarte.ExecuteReader();
                if (readerCarte.Read())
                {
                    carte.AssignerAttaque(Convert.ToInt32(readerCarte["pointsMin"]), Convert.ToInt32(readerCarte["pointsMax"]));
                    carte.AssignerDefense(Convert.ToInt32(readerCarte["pointsDefense"]));
                    carte.AssignerValeurAntidote(readerCarte["nomAntidote"].ToString(), Convert.ToInt32(readerCarte["pointsAntidote"]));
                    categorie.AssignerValeurCategorie(Convert.ToInt32(readerCarte["CategorieCarte"]), readerCarte["nomCategorie"].ToString());
                    carte.AssignerCategorie(categorie);
                    carte.AssignerIdentifiantCarte(readerCarte["identifiant"].ToString());
                    carte.AssignerNomCarte(readerCarte["nomCarte"].ToString());
                }
                readerCarte.Close();
            }
            return carte;
        }
    }
}
