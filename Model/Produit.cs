using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Produit
    {
        public string codart { get; set; }
        public string libelle { get; set; }
        public decimal pri_uni { get; set; }
        public TVA tva { get; set; }
        public int qte_stock { get; set; }
        public int stock_ale { get; set; }
        public Famille f { get; set; }
        public Fournisseur fournisseur { get; set; }

        public Produit()
        {
            tva = new TVA();
            f = new Famille();
            fournisseur = new Fournisseur();
        }

        public Produit(string c, string lib, decimal prix, TVA t, int qte, int ale, Famille f, Fournisseur four)
        {
            tva = new TVA();
            f = new Famille();
            fournisseur = new Fournisseur();
            this.codart = c;
            this.libelle = lib;
            this.pri_uni = prix;
            this.tva = t;
            this.qte_stock = qte;
            this.stock_ale = ale;
            this.f = f;
            this.fournisseur = four; 
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
