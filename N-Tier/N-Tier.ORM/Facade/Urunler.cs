using N_Tier.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Facade
{
    public class Urunler
    {
        //Select
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("select *from Urunler", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
       
        public static bool Insert(Urun u)
        {
            SqlCommand komut = new SqlCommand("insert into Urunler (urunadi,birimfiyati,hedefstokduzeyi," +
                "enazyenidensatismikatari) values (@urunadi,@birimfiyati,@hedefstokduzeyi,@enazyenidensatismikatari)",
                Tools.Baglanti);
            komut.Parameters.AddWithValue("@urunadi", u.UrunAdi);
            komut.Parameters.AddWithValue("@birimfiyati", u.BirimFiyati);
            komut.Parameters.AddWithValue("@hedefstokduzeyi", u.HedefStokDuzeyi);
            komut.Parameters.AddWithValue("@enazyenidensatismikatari", u.EnAzYenidenSatisMiktari);

            return Tools.ExecuteNonQuery(komut);

        }
        //Update
        public static bool Update(Urun u)
        {
            SqlCommand komut = new SqlCommand("update urunler set urunadi=@urunadi,birimfiyati=@birimfiyati," +
                "hedefstokduzeyi=@hedefstokduzeyi,enazyenidensatismikatari=@enazyenidensatismikatari " +
                "where urunId=@urunId");
            komut.Parameters.AddWithValue("@urunadi",u.UrunAdi);
            komut.Parameters.AddWithValue("@birimfiyati",u.BirimFiyati);
            komut.Parameters.AddWithValue("@hedefstokduzeyi",u.HedefStokDuzeyi);
            komut.Parameters.AddWithValue("@enazyenidensatismikatari",u.EnAzYenidenSatisMiktari);
            komut.Parameters.AddWithValue("@urunId", u.UrunId);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);

        }
        //Delete
        public static bool Delete(Urun u)
        {
            SqlCommand komut = new SqlCommand("delete Urunler where urunId=@urunId",Tools.Baglanti);
            komut.Parameters.AddWithValue("@urunId",u.UrunId);
            return Tools.ExecuteNonQuery(komut);
            

        }
    }
}
