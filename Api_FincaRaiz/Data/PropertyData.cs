using Api_FincaRaiz.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Api_FincaRaiz.Data
{
    public class PropertyData
    {
        public static List<Property> ListarPropiedadesPorDueno(int IdOwner)
        {
            List<Property> oListaProperty = new List<Property>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Sp_ViewPropertyOwner", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdOwner", IdOwner);

                try
                {
                    oConexion.Open();
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {

                        while (dr.Read())
                        {
                            oListaProperty.Add(new Property()
                            {
                                IdProperty = Convert.ToInt32(dr["IdProperty"]),
                                Name = dr["Name"].ToString(),
                                Address = dr["Address"].ToString(),
                                Price = Convert.ToInt32(dr["Price"]),
                                CodeInternal = dr["CodeInternal"].ToString(),
                                Year = Convert.ToInt32(dr["Year"]),
                                IdOwner = Convert.ToInt32(dr["IdOwner"])
                            });
                        }

                    }
                    return oListaProperty;
                }
                catch (Exception ex)
                {
                    return oListaProperty;
                }
            }
        }

        public static bool RegistrarPropiedad(Property Pro)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Sp_InsertProperty", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Pro.Name);
                cmd.Parameters.AddWithValue("@Address", Pro.Address);
                cmd.Parameters.AddWithValue("@Price", Pro.Price);
                cmd.Parameters.AddWithValue("@CodeInternal", Pro.CodeInternal);
                cmd.Parameters.AddWithValue("@Year", Pro.Year);
                cmd.Parameters.AddWithValue("@IdOwner", Pro.IdOwner);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public static bool ActualizarPrecioPropiedad(Property Pro)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.RutaConexion))
            {
                SqlCommand cmd = new SqlCommand("Sp_UpdatePriceProperty", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdProperty", Pro.IdProperty);
                cmd.Parameters.AddWithValue("@Price", Pro.Price);      

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}