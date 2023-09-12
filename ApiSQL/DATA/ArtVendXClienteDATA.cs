using ApiSQL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ApiSQL.DATA
{
    public class ArtVendXClienteDATA
    {
        public static List<ArtVendXCliente> listar(String docident)
        {
            List<ArtVendXCliente> oLista = new List<ArtVendXCliente>();
            SqlConnection conexion = new SqlConnection(Conexion.rutaConexion);
            SqlCommand cmd = new SqlCommand("AF_MANAGE_CRUDCLIE", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TIPO", "8");
            cmd.Parameters.AddWithValue("@RUC", docident);
            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        oLista.Add(new ArtVendXCliente()
                        {
                            CodigoArticulo = dr["CodigoArticulo"].ToString(),
                            DescripcionArticulo = dr["DescripcionArticulo"].ToString(),
                            NombreMarca = dr["NombreMarca"].ToString(),
                            PrecioLista = dr["PrecioLista"].ToString(),
                        });
                    }
                    return oLista;
                }
            }catch(Exception ex)
            {
                return oLista;
            }

        }
    }
}