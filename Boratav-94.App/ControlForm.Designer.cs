namespace Boratav_94.App
{
    partial class ControlForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMermi = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pboxMermi = new System.Windows.Forms.PictureBox();
            this.pBoxImha = new System.Windows.Forms.PictureBox();
            this.pboxBaglanti = new System.Windows.Forms.PictureBox();
            this.pboxGunesEnrj = new System.Windows.Forms.PictureBox();
            this.pboxBatarya = new System.Windows.Forms.PictureBox();
            this.kameralar1 = new Boratav_94.App.Bilesenler.Kameralar();
            this._360DrcKontBtn4 = new Boratav_94.App.Bilesenler._360DrcKontBtn._360DrcKontBtn();
            this._360DrcKontBtn3 = new Boratav_94.App.Bilesenler._360DrcKontBtn._360DrcKontBtn();
            this._360DrcKontBtn2 = new Boratav_94.App.Bilesenler._360DrcKontBtn._360DrcKontBtn();
            this._360DrcKontBtn1 = new Boratav_94.App.Bilesenler._360DrcKontBtn._360DrcKontBtn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxMermi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBaglanti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGunesEnrj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBatarya)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this._360DrcKontBtn1);
            this.groupBox1.Location = new System.Drawing.Point(12, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 122);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kamera Kontrol";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "%100";
            // 
            // lblMermi
            // 
            this.lblMermi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMermi.AutoSize = true;
            this.lblMermi.BackColor = System.Drawing.Color.Transparent;
            this.lblMermi.Location = new System.Drawing.Point(445, 138);
            this.lblMermi.Name = "lblMermi";
            this.lblMermi.Size = new System.Drawing.Size(25, 13);
            this.lblMermi.TabIndex = 4;
            this.lblMermi.Text = "200";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this._360DrcKontBtn2);
            this.groupBox2.Location = new System.Drawing.Point(132, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Kontrol";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._360DrcKontBtn3);
            this.groupBox3.Location = new System.Drawing.Point(252, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lazer Kontrol";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._360DrcKontBtn4);
            this.groupBox4.Location = new System.Drawing.Point(372, 179);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(114, 122);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Kol Kontrol";
            // 
            // pboxMermi
            // 
            this.pboxMermi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxMermi.Image = global::Boratav_94.App.Bilesenler.Resimler.mermi;
            this.pboxMermi.Location = new System.Drawing.Point(433, 120);
            this.pboxMermi.Name = "pboxMermi";
            this.pboxMermi.Size = new System.Drawing.Size(48, 48);
            this.pboxMermi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxMermi.TabIndex = 3;
            this.pboxMermi.TabStop = false;
            // 
            // pBoxImha
            // 
            this.pBoxImha.Image = global::Boratav_94.App.Bilesenler.Resimler.imha;
            this.pBoxImha.Location = new System.Drawing.Point(12, 66);
            this.pBoxImha.Name = "pBoxImha";
            this.pBoxImha.Size = new System.Drawing.Size(48, 48);
            this.pBoxImha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxImha.TabIndex = 3;
            this.pBoxImha.TabStop = false;
            // 
            // pboxBaglanti
            // 
            this.pboxBaglanti.Image = global::Boratav_94.App.Bilesenler.Resimler.baglidegil;
            this.pboxBaglanti.Location = new System.Drawing.Point(12, 12);
            this.pboxBaglanti.Name = "pboxBaglanti";
            this.pboxBaglanti.Size = new System.Drawing.Size(48, 48);
            this.pboxBaglanti.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBaglanti.TabIndex = 3;
            this.pboxBaglanti.TabStop = false;
            // 
            // pboxGunesEnrj
            // 
            this.pboxGunesEnrj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxGunesEnrj.Image = global::Boratav_94.App.Bilesenler.Resimler.GunesEnerjisi;
            this.pboxGunesEnrj.Location = new System.Drawing.Point(433, 66);
            this.pboxGunesEnrj.Name = "pboxGunesEnrj";
            this.pboxGunesEnrj.Size = new System.Drawing.Size(48, 48);
            this.pboxGunesEnrj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGunesEnrj.TabIndex = 3;
            this.pboxGunesEnrj.TabStop = false;
            // 
            // pboxBatarya
            // 
            this.pboxBatarya.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxBatarya.Image = global::Boratav_94.App.Bilesenler.Resimler.Batarya;
            this.pboxBatarya.Location = new System.Drawing.Point(433, 12);
            this.pboxBatarya.Name = "pboxBatarya";
            this.pboxBatarya.Size = new System.Drawing.Size(48, 48);
            this.pboxBatarya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxBatarya.TabIndex = 1;
            this.pboxBatarya.TabStop = false;
            // 
            // kameralar1
            // 
            this.kameralar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kameralar1.Location = new System.Drawing.Point(66, 12);
            this.kameralar1.Name = "kameralar1";
            this.kameralar1.Size = new System.Drawing.Size(361, 161);
            this.kameralar1.TabIndex = 5;
            // 
            // _360DrcKontBtn4
            // 
            this._360DrcKontBtn4.Location = new System.Drawing.Point(6, 19);
            this._360DrcKontBtn4.Name = "_360DrcKontBtn4";
            this._360DrcKontBtn4.Size = new System.Drawing.Size(100, 100);
            this._360DrcKontBtn4.TabIndex = 0;
            // 
            // _360DrcKontBtn3
            // 
            this._360DrcKontBtn3.Location = new System.Drawing.Point(6, 19);
            this._360DrcKontBtn3.Name = "_360DrcKontBtn3";
            this._360DrcKontBtn3.Size = new System.Drawing.Size(100, 100);
            this._360DrcKontBtn3.TabIndex = 0;
            // 
            // _360DrcKontBtn2
            // 
            this._360DrcKontBtn2.Location = new System.Drawing.Point(6, 19);
            this._360DrcKontBtn2.Name = "_360DrcKontBtn2";
            this._360DrcKontBtn2.Size = new System.Drawing.Size(100, 100);
            this._360DrcKontBtn2.TabIndex = 0;
            // 
            // _360DrcKontBtn1
            // 
            this._360DrcKontBtn1.Location = new System.Drawing.Point(6, 19);
            this._360DrcKontBtn1.Name = "_360DrcKontBtn1";
            this._360DrcKontBtn1.Size = new System.Drawing.Size(100, 100);
            this._360DrcKontBtn1.TabIndex = 0;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 313);
            this.Controls.Add(this.kameralar1);
            this.Controls.Add(this.lblMermi);
            this.Controls.Add(this.pboxMermi);
            this.Controls.Add(this.pBoxImha);
            this.Controls.Add(this.pboxBaglanti);
            this.Controls.Add(this.pboxGunesEnrj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxBatarya);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(509, 352);
            this.Name = "ControlForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boratav-94";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxMermi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxImha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBaglanti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGunesEnrj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxBatarya)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private Bilesenler._360DrcKontBtn._360DrcKontBtn _360DrcKontBtn1;
        private System.Windows.Forms.PictureBox pboxBatarya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxGunesEnrj;
        private System.Windows.Forms.PictureBox pboxMermi;
        private System.Windows.Forms.Label lblMermi;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bilesenler._360DrcKontBtn._360DrcKontBtn _360DrcKontBtn2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Bilesenler._360DrcKontBtn._360DrcKontBtn _360DrcKontBtn3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Bilesenler._360DrcKontBtn._360DrcKontBtn _360DrcKontBtn4;
        private System.Windows.Forms.PictureBox pboxBaglanti;
        private System.Windows.Forms.PictureBox pBoxImha;
        private Bilesenler.Kameralar kameralar1;
    }
}

