using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Entity
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int TedarikciID { get; set; }
        public int KategoriId { get; set; }
        public string BirimdekiMiktar { get; set; }
        public decimal BirimFiyati { get; set; }
        public short HedefStokDuzeyi { get; set; }
        public short YeniSatis { get; set; }
        public short EnAzYenidenSatisMiktari { get; set; }
        public bool Sonlandi { get; set; }

        public Urun()
        {

        }
        public Urun(string urunAdi, decimal birimFiyati, short hedefStokDuzeyi, short enazyenidensatismiktari)
        {
            this.UrunAdi = urunAdi;
            this.BirimFiyati = birimFiyati;
            this.HedefStokDuzeyi = hedefStokDuzeyi;
            this.EnAzYenidenSatisMiktari = enazyenidensatismiktari;

        }

    }
}
