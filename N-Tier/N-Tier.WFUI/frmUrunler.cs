using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using N_Tier.ORM;
using N_Tier.ORM.Entity;
using N_Tier.ORM.Facade;

namespace N_Tier.WFUI
{
    public partial class frmUrunler : Form
    {
        public frmUrunler()
        {
            InitializeComponent();
            dgvUrunListe.DataSource = Urunler.Select();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != "" && txtBirimFiyati.Text != "")
            {
                if (txtUrunAdi.Text != "" && txtBirimFiyati.Text != "")
                {
                    if (txtHedefStokDuzeyi.Text == "" && txtEnazSatisMiktari.Text == "")
                    {
                        txtHedefStokDuzeyi.Text = txtEnazSatisMiktari.Text = 0.ToString();
                    }
                    string ad = txtUrunAdi.Text;
                    decimal birimFiyati = decimal.Parse(txtBirimFiyati.Text);
                    short hedefStokDuzeyi = short.Parse(txtHedefStokDuzeyi.Text);
                    short enAzSatisMiktari = short.Parse(txtEnazSatisMiktari.Text);
                    Urun urun = new Urun(ad, birimFiyati, hedefStokDuzeyi, enAzSatisMiktari);
                    bool islem = Urunler.Insert(urun);
                    string text = islem == true ? "Urun Eklendi" : "Bir hata oluştu";
                    dgvUrunListe.DataSource = Urunler.Select();
                    MessageBox.Show(text);
                }
                else
                    MessageBox.Show("ürün adı ve birim fiyatını doldurun");
            }
            else
            {
                MessageBox.Show("ürün adı ve birim fiyatı boş olamaz!!");
            }

        }

        private void dgvUrunListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunAdi.Tag = dgvUrunListe.CurrentRow.Cells["UrunId"].Value.ToString();
            txtUrunAdi.Text = dgvUrunListe.CurrentRow.Cells["UrunAdi"].Value.ToString();
            txtBirimFiyati.Text = dgvUrunListe.CurrentRow.Cells["Birimfiyati"].Value.ToString();
            txtHedefStokDuzeyi.Text = dgvUrunListe.CurrentRow.Cells["HedefStokDuzeyi"].Value.ToString();
            txtEnazSatisMiktari.Text = dgvUrunListe.CurrentRow.Cells["EnAzYenidenSatisMikatari"].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if ((string)txtUrunAdi.Tag != "" && txtUrunAdi.Text != "")
            {
                Urun u = new Urun();
                u.UrunId = int.Parse(txtUrunAdi.Tag.ToString());
                bool islem = Urunler.Delete(u);
                string text = islem == true ? "seçili ürün silindi" : "bir hata oluştu";
                MessageBox.Show(text);
                dgvUrunListe.DataSource = Urunler.Select();
            }
            else
            {
                MessageBox.Show("lütfen silinecek ürünü çift tıklayarak seçin");
            }



        }

        private void frmUrunler_Load(object sender, EventArgs e)
        {
            dgvUrunListe.Columns[2].Visible = false;
            dgvUrunListe.Columns[3].Visible = false;
            dgvUrunListe.Columns[4].Visible = false;
            //dgvKategoriListe.Columns[6].Visible = false;
            //dgvKategoriListe.Columns[7].Visible = false;
            //dgvKategoriListe.Columns[1].Visible = false;
        }
        #region e.Handled işlemleri
        private void txtBirimFiyati_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBirimFiyati.Text.Contains(","))
            {
                e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            else
            {
                e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ',';
            }
        }

        private void txtHedefStokDuzeyi_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtEnazSatisMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text != "" && (string)txtUrunAdi.Tag != "" && txtBirimFiyati.Text != "")
            {
                if (txtHedefStokDuzeyi.Text == "" && txtEnazSatisMiktari.Text == "")
                {
                    txtHedefStokDuzeyi.Text = txtEnazSatisMiktari.Text = 0.ToString();
                }
                Urun u = new Urun(txtUrunAdi.Text, decimal.Parse(txtBirimFiyati.Text),
                    short.Parse(txtHedefStokDuzeyi.Text), short.Parse(txtEnazSatisMiktari.Text));
                u.UrunId = int.Parse(txtUrunAdi.Tag.ToString());
                bool islem = Urunler.Update(u);
                string text = islem == true ? "güncelleme işlemi gerçekleşti" : "bir hata oluştu";
                MessageBox.Show(text);
                dgvUrunListe.DataSource = Urunler.Select();
            }
            else if (txtUrunAdi.Text != "" && (string)txtUrunAdi.Tag != "" && txtBirimFiyati.Text == "")
            {
                MessageBox.Show("birim fiyatını boş bırakmayın");
            }
            else
            {
                MessageBox.Show("lütfen güncellecek ürünü çift tıklayarak seçin");
            }
        }

        private void txtUrunAdi_TextChanged(object sender, EventArgs e)
        {
            if (txtUrunAdi.Text == "")
            {
                txtUrunAdi.Tag = "";
            }
        }
    }
}
