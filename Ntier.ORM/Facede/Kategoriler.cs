using Ntier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Ntier.ORM.Facede
{
    public class Kategoriler
    {

        //select
       public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select * from Kategoriler",Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        //Insert
        public static bool Insert(Kategori model)
        {
            SqlCommand cmd = new SqlCommand("prc_kategoriEkle",Tools.Baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@adi", model.KategoriAdi);
            cmd.Parameters.AddWithValue("@tanim", model.Tanimi);

            return Tools.ExecuteNonQuery(cmd);
        }
    }
}
