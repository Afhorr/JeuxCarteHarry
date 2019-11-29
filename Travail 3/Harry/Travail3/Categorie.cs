using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travail3
{
    class Categorie
    {
        private int idCategorie;
        private string nomCategorie;

        public Categorie()
        {
            idCategorie = 0;
            nomCategorie = "";
        }
        public string RecupererNom()
        {
            return nomCategorie;
        }

        public void AssignerValeurCategorie(int id, string nom)
        {
            idCategorie = id;
            nomCategorie = nom;
        }
    }
}
