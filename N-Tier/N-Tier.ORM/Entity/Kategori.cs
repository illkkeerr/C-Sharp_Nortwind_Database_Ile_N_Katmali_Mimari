using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier.ORM.Entity
{
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Tanimi { get; set; }

        public Kategori()
        {

        }
        public Kategori(string kategoriAdi, string tanimi)
        {
            this.KategoriAdi = kategoriAdi;
            this.Tanimi = tanimi;
        }
    }
}
