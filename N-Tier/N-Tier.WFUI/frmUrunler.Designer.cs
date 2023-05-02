namespace N_Tier.WFUI
{
    partial class frmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBirimFiyati = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.dgvUrunListe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEnazSatisMiktari = new System.Windows.Forms.TextBox();
            this.txtHedefStokDuzeyi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(205, 338);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(157, 28);
            this.btnTemizle.TabIndex = 17;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(205, 303);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(157, 28);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(205, 267);
            this.btnSil.Margin = new System.Windows.Forms.Padding(4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(157, 28);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(205, 231);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(157, 28);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Birim Fiyatı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Adı";
            // 
            // txtBirimFiyati
            // 
            this.txtBirimFiyati.Location = new System.Drawing.Point(205, 100);
            this.txtBirimFiyati.Margin = new System.Windows.Forms.Padding(4);
            this.txtBirimFiyati.Name = "txtBirimFiyati";
            this.txtBirimFiyati.Size = new System.Drawing.Size(157, 22);
            this.txtBirimFiyati.TabIndex = 11;
            this.txtBirimFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBirimFiyati_KeyPress);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(205, 57);
            this.txtUrunAdi.Margin = new System.Windows.Forms.Padding(4);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(157, 22);
            this.txtUrunAdi.TabIndex = 10;
            this.txtUrunAdi.TextChanged += new System.EventHandler(this.txtUrunAdi_TextChanged);
            // 
            // dgvUrunListe
            // 
            this.dgvUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunListe.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvUrunListe.Location = new System.Drawing.Point(478, 0);
            this.dgvUrunListe.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUrunListe.Name = "dgvUrunListe";
            this.dgvUrunListe.RowHeadersWidth = 51;
            this.dgvUrunListe.Size = new System.Drawing.Size(789, 554);
            this.dgvUrunListe.TabIndex = 9;
            this.dgvUrunListe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunListe_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "En Az Yeniden Satış Miktarı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Hedef Stok Düzeyi";
            // 
            // txtEnazSatisMiktari
            // 
            this.txtEnazSatisMiktari.Location = new System.Drawing.Point(205, 186);
            this.txtEnazSatisMiktari.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnazSatisMiktari.Name = "txtEnazSatisMiktari";
            this.txtEnazSatisMiktari.Size = new System.Drawing.Size(157, 22);
            this.txtEnazSatisMiktari.TabIndex = 19;
            this.txtEnazSatisMiktari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnazSatisMiktari_KeyPress);
            // 
            // txtHedefStokDuzeyi
            // 
            this.txtHedefStokDuzeyi.Location = new System.Drawing.Point(205, 143);
            this.txtHedefStokDuzeyi.Margin = new System.Windows.Forms.Padding(4);
            this.txtHedefStokDuzeyi.Name = "txtHedefStokDuzeyi";
            this.txtHedefStokDuzeyi.Size = new System.Drawing.Size(157, 22);
            this.txtHedefStokDuzeyi.TabIndex = 18;
            this.txtHedefStokDuzeyi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHedefStokDuzeyi_KeyPress);
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEnazSatisMiktari);
            this.Controls.Add(this.txtHedefStokDuzeyi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBirimFiyati);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.dgvUrunListe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUrunler";
            this.Load += new System.EventHandler(this.frmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBirimFiyati;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.DataGridView dgvUrunListe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEnazSatisMiktari;
        private System.Windows.Forms.TextBox txtHedefStokDuzeyi;
    }
}