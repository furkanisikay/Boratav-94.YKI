namespace Boratav_94.App.Bilesenler
{
    partial class Kameralar
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxKam4 = new System.Windows.Forms.PictureBox();
            this.pboxKam2 = new System.Windows.Forms.PictureBox();
            this.pboxKam3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pboxKam1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pboxKam4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pboxKam2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pboxKam3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(343, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(165, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // pboxKam4
            // 
            this.pboxKam4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxKam4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxKam4.Image = global::Boratav_94.App.Bilesenler.Resimler.disconnectedGPS;
            this.pboxKam4.Location = new System.Drawing.Point(3, 169);
            this.pboxKam4.Name = "pboxKam4";
            this.pboxKam4.Size = new System.Drawing.Size(159, 78);
            this.pboxKam4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKam4.TabIndex = 4;
            this.pboxKam4.TabStop = false;
            // 
            // pboxKam2
            // 
            this.pboxKam2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxKam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxKam2.Image = global::Boratav_94.App.Bilesenler.Resimler.disconnectedGPS;
            this.pboxKam2.Location = new System.Drawing.Point(3, 3);
            this.pboxKam2.Name = "pboxKam2";
            this.pboxKam2.Size = new System.Drawing.Size(159, 77);
            this.pboxKam2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKam2.TabIndex = 2;
            this.pboxKam2.TabStop = false;
            // 
            // pboxKam3
            // 
            this.pboxKam3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxKam3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxKam3.Image = global::Boratav_94.App.Bilesenler.Resimler.disconnectedGPS;
            this.pboxKam3.Location = new System.Drawing.Point(3, 86);
            this.pboxKam3.Name = "pboxKam3";
            this.pboxKam3.Size = new System.Drawing.Size(159, 77);
            this.pboxKam3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxKam3.TabIndex = 3;
            this.pboxKam3.TabStop = false;
            this.pboxKam3.Click += new System.EventHandler(this.pboxKam3_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.67F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.pboxKam1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 256);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // pboxKam1
            // 
            this.pboxKam1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pboxKam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pboxKam1.Image = global::Boratav_94.App.Bilesenler.Resimler.disconnectedGPS;
            this.pboxKam1.Location = new System.Drawing.Point(3, 3);
            this.pboxKam1.Name = "pboxKam1";
            this.pboxKam1.Size = new System.Drawing.Size(334, 250);
            this.pboxKam1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pboxKam1.TabIndex = 1;
            this.pboxKam1.TabStop = false;
            // 
            // Kameralar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "Kameralar";
            this.Size = new System.Drawing.Size(511, 256);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxKam1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pboxKam3;
        private System.Windows.Forms.PictureBox pboxKam2;
        private System.Windows.Forms.PictureBox pboxKam1;
        private System.Windows.Forms.PictureBox pboxKam4;
    }
}