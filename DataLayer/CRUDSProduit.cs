using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class CRUDSProduit
    {
        public List<Model.Produit> listeProduit()
        {
            try
            {
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        List<Model.Produit> listeProduit = new List<Model.Produit>();
                        Model.Produit P=null;

                        cmd.CommandText = "";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Connection = co;
                        SqlDataReader dr = cmd.ExecuteReader();

                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P = new Model.Produit();
                                listeProduit.Add(P);
                            }
                        }
                        return listeProduit;
                    }

                }
                
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }


           
        }

        public Model.Produit getProduit(string code)
        {
            try
            {
                
                using (SqlConnection co = ConnexionDB.getConnection())
                {
                    using (SqlCommand cmd = co.CreateCommand())
                    {
                        Model.Produit P= null;
                        cmd.CommandText = "";
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.Add(new SqlParameter("@code", SqlDbType.NVarChar)).Value = code;
                        cmd.Connection = co;
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                P =new Model.Produit();

                            }
                        }
                        return P;
                    }
                   
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
