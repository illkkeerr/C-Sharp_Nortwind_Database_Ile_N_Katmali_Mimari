using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N_Tier.ORM.Facade;
using N_Tier.ORM.Entity;



namespace N_Tier.WFUI
{
    public partial class frmKategoriler : Form
    {
        public frmKategoriler()
        {
            InitializeComponent();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            dgvKategoriListe.RowTemplate.Height = 120;
            dgvKategoriListe.DataSource = ORM.Facade.Kategoriler.Select();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && txtKategoriTanim.Text != "")
            {
                Kategori kategori = new Kategori(txtKategoriAd.Text, txtKategoriTanim.Text);
                bool islem = ORM.Facade.Kategoriler.Insert(kategori);
                string text = islem == true ? "yeni kategori eklendi" : "bir hata oluştu";
                MessageBox.Show(text);
                dgvKategoriListe.DataSource = ORM.Facade.Kategoriler.Select();

            }
            else
            {
                MessageBox.Show("lütfen boş alanları doldurun");
            }
        }

        private void dgvKategoriListe_DoubleClick(object sender, EventArgs e)
        {
            //Taglı işlem
            txtKategoriAd.Tag = dgvKategoriListe.CurrentRow.Cells["KategoriId"].Value.ToString();
            txtKategoriAd.Text = dgvKategoriListe.CurrentRow.Cells["KategoriAdi"].Value.ToString();
            txtKategoriTanim.Text = dgvKategoriListe.CurrentRow.Cells["Tanimi"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && (string)txtKategoriAd.Tag != "")
            {
                Kategori k = new Kategori();
                //k.KategoriID = int.Parse(dgvKategoriListe.CurrentRow.Cells["KategoriId"].Value.ToString());
                k.KategoriID = int.Parse(txtKategoriAd.Tag.ToString());
                bool islem = ORM.Facade.Kategoriler.Delete(k);
                string text = islem == true ? "silme işlemi gerçekleşti" : "bir hata oluştu";
                MessageBox.Show(text);
                dgvKategoriListe.DataSource = Kategoriler.Select();
            }
            else
            {
                MessageBox.Show("silmek istediğiniz ürünün üstüne çift tılayın");
            }



        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text != "" && txtKategoriTanim.Text != "")
            {
                Kategori k = new Kategori(txtKategoriAd.Text, txtKategoriTanim.Text);
                //k.KategoriID = int.Parse(dgvKategoriListe.CurrentRow.Cells["KategoriId"].Value.ToString());
                k.KategoriID = int.Parse(txtKategoriAd.Tag.ToString());

                bool islem = Kategoriler.Update(k);
                string text = islem == true ? "güncelleme işlemi gerçekleşti" : "bir hata oluştu";
                MessageBox.Show(text);
                dgvKategoriListe.DataSource = Kategoriler.Select();


            }
            else if (txtKategoriTanim.Text == "" && txtKategoriAd.Text != "")
            {
                MessageBox.Show("Kategori tanımını boş bırakmayın.");
            }
            else
            {
                MessageBox.Show("güncelleme işlemini yapmak istediğiniz ürünün üstüne çift tıklayın");
            }
        }

        private void dgvKategoriListe_SelectionChanged(object sender, EventArgs e)
        {
            txtKategoriAd.Text = txtKategoriTanim.Text = "";
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            txtKategoriAd.Text = txtKategoriTanim.Text = "";
            txtKategoriAd.Tag = "";
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            frmUrunler urunler = new frmUrunler();
            urunler.ShowDialog();

        }

        private void txtKategoriAd_TextChanged(object sender, EventArgs e)
        {
            if (txtKategoriAd.Text == "")
                txtKategoriAd.Tag = "";
        }
    }
}
