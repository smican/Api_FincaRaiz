using Api_FincaRaiz.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Api_FincaRaiz.Data
{
    public class OwnerData
    {
        public static List<Owner> ListarOwner()
        {
            List<Owner> oListaOwner = new List<Owner>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Sp_ViewOwner", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaOwner.Add(new Owner()
                            {
                                IdOwner = Convert.ToInt32(dr["IdOwner"]),
                                NameOwner = dr["NameOwner"].ToString(),
                                Address = dr["Address"].ToString(),
                                Photo = dr["Photo"].ToString(),
                                Birthday = dr["Birthday"].ToString().Substring(0,10),
                                
                            });
                        }

                    }
                    return oListaOwner;
                }
                catch (Exception ex)
                {
                    return oListaOwner;
                }
            }
        }
    }
}