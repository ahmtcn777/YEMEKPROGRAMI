namespace YEMEK_PROGRAMI.Forms
{
    partial class EditYemek
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
            this.tb_fiyat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_yemekAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_kaydet = new MetroFramework.Controls.MetroButton();
            this.btn_sil = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_fiyat
            // 
            // 
            // 
            // 
            this.tb_fiyat.CustomButton.Image = null;
            this.tb_fiyat.CustomButton.Location = new System.Drawing.Point(29, 1);
            this.tb_fiyat.CustomButton.Name = "";
            this.tb_fiyat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_fiyat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_fiyat.CustomButton.TabIndex = 1;
            this.tb_fiyat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_fiyat.CustomButton.UseSelectable = true;
            this.tb_fiyat.CustomButton.Visible = false;
            this.tb_fiyat.Lines = new string[0];
            this.tb_fiyat.Location = new System.Drawing.Point(126, 162);
            this.tb_fiyat.MaxLength = 32767;
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.PasswordChar = '\0';
            this.tb_fiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fiyat.SelectedText = "";
            this.tb_fiyat.SelectionLength = 0;
            this.tb_fiyat.SelectionStart = 0;
            this.tb_fiyat.ShortcutsEnabled = true;
            this.tb_fiyat.Size = new System.Drawing.Size(51, 23);
            this.tb_fiyat.TabIndex = 9;
            this.tb_fiyat.UseSelectable = true;
            this.tb_fiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(81, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Fiyat:";
            // 
            // tb_yemekAdi
            // 
            // 
            // 
            // 
            this.tb_yemekAdi.CustomButton.Image = null;
            this.tb_yemekAdi.CustomButton.Location = new System.Drawing.Point(303, 1);
            this.tb_yemekAdi.CustomButton.Name = "";
            this.tb_yemekAdi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_yemekAdi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_yemekAdi.CustomButton.TabIndex = 1;
            this.tb_yemekAdi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_yemekAdi.CustomButton.UseSelectable = true;
            this.tb_yemekAdi.CustomButton.Visible = false;
            this.tb_yemekAdi.Lines = new string[0];
            this.tb_yemekAdi.Location = new System.Drawing.Point(126, 124);
            this.tb_yemekAdi.MaxLength = 32767;
            this.tb_yemekAdi.Name = "tb_yemekAdi";
            this.tb_yemekAdi.PasswordChar = '\0';
            this.tb_yemekAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_yemekAdi.SelectedText = "";
            this.tb_yemekAdi.SelectionLength = 0;
            this.tb_yemekAdi.SelectionStart = 0;
            this.tb_yemekAdi.ShortcutsEnabled = true;
            this.tb_yemekAdi.Size = new System.Drawing.Size(325, 23);
            this.tb_yemekAdi.TabIndex = 7;
            this.tb_yemekAdi.UseSelectable = true;
            this.tb_yemekAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_yemekAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(46, 128);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Yemek Adı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::YEMEK_PROGRAMI.Properties.Resources.back32_icon;
            this.pictureBox1.Location = new System.Drawing.Point(46, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(376, 191);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseSelectable = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(376, 80);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 13;
            this.btn_sil.Text = "Yemeği Sil";
            this.btn_sil.UseSelectable = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // EditYemek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 452);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_fiyat);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.tb_yemekAdi);
            this.Controls.Add(this.metroLabel3);
            this.Name = "EditYemek";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox tb_fiyat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_yemekAdi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_kaydet;
        private MetroFramework.Controls.MetroButton btn_sil;
    }
}