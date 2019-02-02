namespace YEMEK_PROGRAMI.Forms
{
    partial class MenuOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuOlustur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_print = new System.Windows.Forms.PictureBox();
            this.btn_geri = new System.Windows.Forms.PictureBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_silDis = new System.Windows.Forms.PictureBox();
            this.btn_ekleDis = new System.Windows.Forms.PictureBox();
            this.btn_silSecilen = new System.Windows.Forms.PictureBox();
            this.btn_ekleSecilen = new System.Windows.Forms.PictureBox();
            this.btn_kaydet = new MetroFramework.Controls.MetroButton();
            this.btn_sagaGonder = new System.Windows.Forms.PictureBox();
            this.btn_solaGonder = new System.Windows.Forms.PictureBox();
            this.lb_dis = new System.Windows.Forms.ListBox();
            this.lb_secilen = new System.Windows.Forms.ListBox();
            this.print_yazici = new System.Drawing.Printing.PrintDocument();
            this.print_dialog = new System.Windows.Forms.PrintPreviewDialog();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.print_yazici2 = new System.Drawing.Printing.PrintDocument();
            this.print_dialog2 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_silDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekleDis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_silSecilen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekleSecilen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sagaGonder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_solaGonder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_print);
            this.panel1.Controls.Add(this.btn_geri);
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 84);
            this.panel1.TabIndex = 1;
            // 
            // pb_print
            // 
            this.pb_print.Image = global::YEMEK_PROGRAMI.Properties.Resources.print_icon;
            this.pb_print.Location = new System.Drawing.Point(339, 14);
            this.pb_print.Name = "pb_print";
            this.pb_print.Size = new System.Drawing.Size(64, 64);
            this.pb_print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_print.TabIndex = 5;
            this.pb_print.TabStop = false;
            this.pb_print.Click += new System.EventHandler(this.pb_print_Click);
            // 
            // btn_geri
            // 
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.Image = global::YEMEK_PROGRAMI.Properties.Resources.back32_icon;
            this.btn_geri.Location = new System.Drawing.Point(20, 21);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(32, 32);
            this.btn_geri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_geri.TabIndex = 4;
            this.btn_geri.TabStop = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(431, 59);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(264, 25);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Menüye Dahil Olmayan Yemekler";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(86, 59);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(232, 25);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Menüye Dahil Olan Yemekler";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.btn_silDis);
            this.panel2.Controls.Add(this.btn_ekleDis);
            this.panel2.Controls.Add(this.btn_silSecilen);
            this.panel2.Controls.Add(this.btn_ekleSecilen);
            this.panel2.Controls.Add(this.btn_kaydet);
            this.panel2.Controls.Add(this.btn_sagaGonder);
            this.panel2.Controls.Add(this.btn_solaGonder);
            this.panel2.Controls.Add(this.lb_dis);
            this.panel2.Controls.Add(this.lb_secilen);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(20, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 286);
            this.panel2.TabIndex = 2;
            // 
            // btn_silDis
            // 
            this.btn_silDis.Image = global::YEMEK_PROGRAMI.Properties.Resources.remove_icon16;
            this.btn_silDis.Location = new System.Drawing.Point(472, 28);
            this.btn_silDis.Name = "btn_silDis";
            this.btn_silDis.Size = new System.Drawing.Size(16, 16);
            this.btn_silDis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_silDis.TabIndex = 12;
            this.btn_silDis.TabStop = false;
            this.btn_silDis.Click += new System.EventHandler(this.btn_silDis_Click);
            // 
            // btn_ekleDis
            // 
            this.btn_ekleDis.Image = global::YEMEK_PROGRAMI.Properties.Resources.add_icon16;
            this.btn_ekleDis.Location = new System.Drawing.Point(472, 6);
            this.btn_ekleDis.Name = "btn_ekleDis";
            this.btn_ekleDis.Size = new System.Drawing.Size(16, 16);
            this.btn_ekleDis.TabIndex = 11;
            this.btn_ekleDis.TabStop = false;
            this.btn_ekleDis.Click += new System.EventHandler(this.btn_ekleDis_Click);
            // 
            // btn_silSecilen
            // 
            this.btn_silSecilen.Image = global::YEMEK_PROGRAMI.Properties.Resources.remove_icon16;
            this.btn_silSecilen.Location = new System.Drawing.Point(106, 28);
            this.btn_silSecilen.Name = "btn_silSecilen";
            this.btn_silSecilen.Size = new System.Drawing.Size(16, 16);
            this.btn_silSecilen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btn_silSecilen.TabIndex = 10;
            this.btn_silSecilen.TabStop = false;
            this.btn_silSecilen.Click += new System.EventHandler(this.btn_silSecilen_Click);
            // 
            // btn_ekleSecilen
            // 
            this.btn_ekleSecilen.Image = global::YEMEK_PROGRAMI.Properties.Resources.add_icon16;
            this.btn_ekleSecilen.Location = new System.Drawing.Point(106, 6);
            this.btn_ekleSecilen.Name = "btn_ekleSecilen";
            this.btn_ekleSecilen.Size = new System.Drawing.Size(16, 16);
            this.btn_ekleSecilen.TabIndex = 9;
            this.btn_ekleSecilen.TabStop = false;
            this.btn_ekleSecilen.Click += new System.EventHandler(this.btn_ekleSecilen_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(328, 233);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 8;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseSelectable = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_yazdir_Click);
            // 
            // btn_sagaGonder
            // 
            this.btn_sagaGonder.BackColor = System.Drawing.Color.Transparent;
            this.btn_sagaGonder.Image = global::YEMEK_PROGRAMI.Properties.Resources.right_arrow_icon;
            this.btn_sagaGonder.Location = new System.Drawing.Point(349, 86);
            this.btn_sagaGonder.Name = "btn_sagaGonder";
            this.btn_sagaGonder.Size = new System.Drawing.Size(32, 32);
            this.btn_sagaGonder.TabIndex = 7;
            this.btn_sagaGonder.TabStop = false;
            this.btn_sagaGonder.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btn_solaGonder
            // 
            this.btn_solaGonder.BackColor = System.Drawing.Color.Transparent;
            this.btn_solaGonder.Image = global::YEMEK_PROGRAMI.Properties.Resources.left_arrow_icon;
            this.btn_solaGonder.Location = new System.Drawing.Point(349, 138);
            this.btn_solaGonder.Name = "btn_solaGonder";
            this.btn_solaGonder.Size = new System.Drawing.Size(32, 32);
            this.btn_solaGonder.TabIndex = 6;
            this.btn_solaGonder.TabStop = false;
            this.btn_solaGonder.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_dis
            // 
            this.lb_dis.FormattingEnabled = true;
            this.lb_dis.Location = new System.Drawing.Point(494, 6);
            this.lb_dis.Name = "lb_dis";
            this.lb_dis.Size = new System.Drawing.Size(120, 251);
            this.lb_dis.TabIndex = 2;
            // 
            // lb_secilen
            // 
            this.lb_secilen.FormattingEnabled = true;
            this.lb_secilen.Location = new System.Drawing.Point(128, 6);
            this.lb_secilen.Name = "lb_secilen";
            this.lb_secilen.Size = new System.Drawing.Size(120, 251);
            this.lb_secilen.TabIndex = 1;
            // 
            // print_yazici
            // 
            this.print_yazici.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_yazici_PrintPage);
            // 
            // print_dialog
            // 
            this.print_dialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_dialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_dialog.ClientSize = new System.Drawing.Size(400, 300);
            this.print_dialog.Document = this.print_yazici;
            this.print_dialog.Enabled = true;
            this.print_dialog.Icon = ((System.Drawing.Icon)(resources.GetObject("print_dialog.Icon")));
            this.print_dialog.Name = "print_dialog";
            this.print_dialog.Visible = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(290, 6);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(155, 23);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Broşür olarak yazdır";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // print_yazici2
            // 
            this.print_yazici2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_yazici2_PrintPage);
            // 
            // print_dialog2
            // 
            this.print_dialog2.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.print_dialog2.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.print_dialog2.ClientSize = new System.Drawing.Size(400, 300);
            this.print_dialog2.Document = this.print_yazici2;
            this.print_dialog2.Enabled = true;
            this.print_dialog2.Icon = ((System.Drawing.Icon)(resources.GetObject("print_dialog2.Icon")));
            this.print_dialog2.Name = "print_dialog2";
            this.print_dialog2.Visible = false;
            // 
            // MenuOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MenuOlustur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_geri)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_silDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekleDis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_silSecilen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_ekleSecilen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_sagaGonder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_solaGonder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lb_dis;
        private System.Windows.Forms.ListBox lb_secilen;
        private System.Windows.Forms.PictureBox btn_sagaGonder;
        private System.Windows.Forms.PictureBox btn_solaGonder;
        private MetroFramework.Controls.MetroButton btn_kaydet;
        private System.Windows.Forms.PictureBox btn_silSecilen;
        private System.Windows.Forms.PictureBox btn_ekleSecilen;
        private System.Windows.Forms.PictureBox btn_silDis;
        private System.Windows.Forms.PictureBox btn_ekleDis;
        private System.Windows.Forms.PictureBox btn_geri;
        private System.Windows.Forms.PictureBox pb_print;
        private System.Drawing.Printing.PrintDocument print_yazici;
        private System.Windows.Forms.PrintPreviewDialog print_dialog;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Drawing.Printing.PrintDocument print_yazici2;
        private System.Windows.Forms.PrintPreviewDialog print_dialog2;
    }
}