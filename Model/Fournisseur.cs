using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Fournisseur
    {
        public int id_fournisseur { get; set; }
        public string nom_fournisseur { get; set; }

        public Fournisseur()
        { }

        public Fournisseur(int id, string nom)
        {
            this.id_fournisseur = id;
            this.nom_fournisseur = nom;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
