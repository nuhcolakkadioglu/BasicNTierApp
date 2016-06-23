using Ntier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Ntier.ORM.Facede
{
    public class Urunler
    {
        //select
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Urunler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }
        //Insert
        public static bool Insert(Urun model)
        {
            SqlCommand cmd = new SqlCommand("prc_urunEkle", Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@urunAdi", model.UrunAdi);
            cmd.Parameters.AddWithValue("@fiyat", model.Fiyat);
            cmd.Parameters.AddWithValue("@stok", model.Stok);
            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
