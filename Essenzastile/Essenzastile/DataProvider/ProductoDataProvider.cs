﻿using System.Data;
using System.Data.SqlClient;

namespace Essenzastile.DataProvider
{
    public class ProductoDataProvider
    {
        public DataTable GetAllProducts()
        {
            SqlConnection con = new SqlConnection(ConexionString.conexion);
            SqlDataAdapter da = new SqlDataAdapter("SPS_LIST_ALL_PRODUCTS", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}