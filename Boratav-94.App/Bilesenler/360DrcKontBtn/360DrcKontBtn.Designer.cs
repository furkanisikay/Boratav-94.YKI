namespace Boratav_94.App.Bilesenler._360DrcKontBtn
{
    partial class _360DrcKontBtn
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSifirla = new System.Windows.Forms.Button();
            this.btnAsagi = new System.Windows.Forms.Button();
            this.btnYukarı = new System.Windows.Forms.Button();
            this.btnSola = new System.Windows.Forms.Button();
            this.btnSaga = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(38, 38);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(24, 24);
            this.btnSifirla.TabIndex = 1;
            this.btnSifirla.Text = "●";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnAsagi
            // 
            this.btnAsagi.Location = new System.Drawing.Point(38, 68);
            this.btnAsagi.Name = "btnAsagi";
            this.btnAsagi.Size = new System.Drawing.Size(24, 24);
            this.btnAsagi.TabIndex = 2;
            this.btnAsagi.Text = "˅";
            this.btnAsagi.UseVisualStyleBackColor = true;
            this.btnAsagi.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnYukarı
            // 
            this.btnYukarı.Location = new System.Drawing.Point(38, 8);
            this.btnYukarı.Name = "btnYukarı";
            this.btnYukarı.Size = new System.Drawing.Size(24, 24);
            this.btnYukarı.TabIndex = 3;
            this.btnYukarı.Text = "˄";
            this.btnYukarı.UseVisualStyleBackColor = true;
            this.btnYukarı.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnSola
            // 
            this.btnSola.Location = new System.Drawing.Point(8, 38);
            this.btnSola.Name = "btnSola";
            this.btnSola.Size = new System.Drawing.Size(24, 24);
            this.btnSola.TabIndex = 4;
            this.btnSola.Text = "<";
            this.btnSola.UseVisualStyleBackColor = true;
            this.btnSola.Click += new System.EventHandler(this.Btn_Click);
            // 
            // btnSaga
            // 
            this.btnSaga.Location = new System.Drawing.Point(68, 38);
            this.btnSaga.Name = "btnSaga";
            this.btnSaga.Size = new System.Drawing.Size(24, 24);
            this.btnSaga.TabIndex = 5;
            this.btnSaga.Text = ">";
            this.btnSaga.UseVisualStyleBackColor = true;
            this.btnSaga.Click += new System.EventHandler(this.Btn_Click);
            // 
            // _360DrcKontBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnAsagi);
            this.Controls.Add(this.btnYukarı);
            this.Controls.Add(this.btnSola);
            this.Controls.Add(this.btnSaga);
            this.Name = "_360DrcKontBtn";
            this.Size = new System.Drawing.Size(100, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Button btnAsagi;
        private System.Windows.Forms.Button btnYukarı;
        private System.Windows.Forms.Button btnSola;
        private System.Windows.Forms.Button btnSaga;
    }
}