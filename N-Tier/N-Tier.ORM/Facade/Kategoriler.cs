using N_Tier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Facade
{
    public class Kategoriler
    {
        //Select metodu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Kategoriler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        //insert metodu
        public static bool Insert(Kategori k)
        {
            SqlCommand komut = new SqlCommand("insert Kategoriler (KategoriAdi,Tanimi) values (@Adi,@Tanimi) ");
            //SqlCommand komut = new SqlCommand("UrunEkle",baglanti);//sql de procedure olursa
            //komut.CommandType = CommandType.StoredProcedure;//sql de procedure olursa
            komut.Parameters.AddWithValue("@Adi", k.KategoriAdi);
            komut.Parameters.AddWithValue("@Tanimi", k.Tanimi);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        //Update metodu
        public static bool Update(Kategori k)
        {
            SqlCommand komut = new SqlCommand("Update Kategoriler set Kategoriadi=@kategoriadi,Tanimi=@tanimi " +
                "where kategoriId=@kategoriId", Tools.Baglanti);
            komut.Parameters.AddWithValue("@kategoriadi", k.KategoriAdi);
            komut.Parameters.AddWithValue("@tanimi", k.Tanimi);
            komut.Parameters.AddWithValue("@kategoriId", k.KategoriID);
            return Tools.ExecuteNonQuery(komut);
        }
        //Delete metodu
        public static bool Delete(Kategori k)
        {
            SqlCommand komut = new SqlCommand("Delete Kategoriler where KategoriId=@KategoriId");
            komut.Parameters.AddWithValue("@KategoriId", k.KategoriID);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

    }
}
