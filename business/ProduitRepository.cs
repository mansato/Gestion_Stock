using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProduitRepository
    {
        public List<Model.Produit> listeProduit()
        {
            try
            {
                List<Model.Produit> listProduit = new List<Model.Produit>();
              // listProduit = DataLayer.CRUDSProduit
                return listProduit;

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
