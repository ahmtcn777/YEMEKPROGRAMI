namespace YEMEK_PROGRAMI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainTab = new MetroFramework.Controls.MetroTabControl();
            this.Anasayfa = new MetroFramework.Controls.MetroTabPage();
            this.yemekListesi = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.yemekEkleTab = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btn_yemekKayit = new MetroFramework.Controls.MetroButton();
            this.tb_fiyat = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.tb_yemekAdi = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.menuOlustur = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.btn_devam = new MetroFramework.Controls.MetroButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_selectedList = new System.Windows.Forms.ListBox();
            this.lb_dbList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.menuDuzenle = new MetroFramework.Controls.MetroTabPage();
            this.menuListesi = new MetroFramework.Controls.MetroGrid();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tb_phone = new System.Windows.Forms.MaskedTextBox();
            this.tb_company = new MetroFramework.Controls.MetroTextBox();
            this.tb_azTabak = new MetroFramework.Controls.MetroTextBox();
            this.tb_tamTabak = new MetroFramework.Controls.MetroTextBox();
            this.tb_des1 = new MetroFramework.Controls.MetroTextBox();
            this.tb_des2 = new MetroFramework.Controls.MetroTextBox();
            this.btn_kaydetAyarlar = new MetroFramework.Controls.MetroButton();
            this.mainTab.SuspendLayout();
            this.Anasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekListesi)).BeginInit();
            this.yemekEkleTab.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.menuOlustur.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuDuzenle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.Anasayfa);
            this.mainTab.Controls.Add(this.yemekEkleTab);
            this.mainTab.Controls.Add(this.menuOlustur);
            this.mainTab.Controls.Add(this.menuDuzenle);
            this.mainTab.Controls.Add(this.metroTabPage1);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTab.Location = new System.Drawing.Point(20, 60);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(434, 369);
            this.mainTab.TabIndex = 0;
            this.mainTab.UseSelectable = true;
            this.mainTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.mainTab_Selected);
            // 
            // Anasayfa
            // 
            this.Anasayfa.Controls.Add(this.yemekListesi);
            this.Anasayfa.Controls.Add(this.metroLabel1);
            this.Anasayfa.HorizontalScrollbarBarColor = true;
            this.Anasayfa.HorizontalScrollbarHighlightOnWheel = false;
            this.Anasayfa.HorizontalScrollbarSize = 10;
            this.Anasayfa.Location = new System.Drawing.Point(4, 38);
            this.Anasayfa.Name = "Anasayfa";
            this.Anasayfa.Size = new System.Drawing.Size(426, 327);
            this.Anasayfa.TabIndex = 0;
            this.Anasayfa.Text = "Anasayfa";
            this.Anasayfa.VerticalScrollbarBarColor = true;
            this.Anasayfa.VerticalScrollbarHighlightOnWheel = false;
            this.Anasayfa.VerticalScrollbarSize = 10;
            // 
            // yemekListesi
            // 
            this.yemekListesi.AllowUserToResizeRows = false;
            this.yemekListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yemekListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yemekListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.yemekListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yemekListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.yemekListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yemekListesi.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.yemekListesi.DefaultCellStyle = dataGridViewCellStyle2;
            this.yemekListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yemekListesi.EnableHeadersVisualStyles = false;
            this.yemekListesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yemekListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.yemekListesi.Location = new System.Drawing.Point(0, 25);
            this.yemekListesi.Name = "yemekListesi";
            this.yemekListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.yemekListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.yemekListesi.RowHeadersVisible = false;
            this.yemekListesi.RowHeadersWidth = 70;
            this.yemekListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yemekListesi.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.yemekListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.yemekListesi.Size = new System.Drawing.Size(426, 302);
            this.yemekListesi.TabIndex = 5;
            this.yemekListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.yemekListesi_CellDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(0, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(110, 25);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Yemek Listesi";
            // 
            // yemekEkleTab
            // 
            this.yemekEkleTab.Controls.Add(this.metroPanel1);
            this.yemekEkleTab.Controls.Add(this.metroLabel2);
            this.yemekEkleTab.HorizontalScrollbarBarColor = true;
            this.yemekEkleTab.HorizontalScrollbarHighlightOnWheel = false;
            this.yemekEkleTab.HorizontalScrollbarSize = 10;
            this.yemekEkleTab.Location = new System.Drawing.Point(4, 38);
            this.yemekEkleTab.Name = "yemekEkleTab";
            this.yemekEkleTab.Size = new System.Drawing.Size(426, 327);
            this.yemekEkleTab.TabIndex = 1;
            this.yemekEkleTab.Text = "Yemek Ekle";
            this.yemekEkleTab.VerticalScrollbarBarColor = true;
            this.yemekEkleTab.VerticalScrollbarHighlightOnWheel = false;
            this.yemekEkleTab.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btn_yemekKayit);
            this.metroPanel1.Controls.Add(this.tb_fiyat);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.tb_yemekAdi);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 25);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(426, 302);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btn_yemekKayit
            // 
            this.btn_yemekKayit.Location = new System.Drawing.Point(333, 89);
            this.btn_yemekKayit.Name = "btn_yemekKayit";
            this.btn_yemekKayit.Size = new System.Drawing.Size(75, 23);
            this.btn_yemekKayit.TabIndex = 6;
            this.btn_yemekKayit.Text = "Kaydet";
            this.btn_yemekKayit.UseSelectable = true;
            this.btn_yemekKayit.Click += new System.EventHandler(this.btn_yemekKayit_Click);
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
            this.tb_fiyat.Location = new System.Drawing.Point(83, 60);
            this.tb_fiyat.MaxLength = 32767;
            this.tb_fiyat.Name = "tb_fiyat";
            this.tb_fiyat.PasswordChar = '\0';
            this.tb_fiyat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_fiyat.SelectedText = "";
            this.tb_fiyat.SelectionLength = 0;
            this.tb_fiyat.SelectionStart = 0;
            this.tb_fiyat.ShortcutsEnabled = true;
            this.tb_fiyat.Size = new System.Drawing.Size(51, 23);
            this.tb_fiyat.TabIndex = 5;
            this.tb_fiyat.UseSelectable = true;
            this.tb_fiyat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_fiyat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_fiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_fiyat_KeyPress);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(38, 60);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(39, 19);
            this.metroLabel4.TabIndex = 4;
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
            this.tb_yemekAdi.Location = new System.Drawing.Point(83, 22);
            this.tb_yemekAdi.MaxLength = 32767;
            this.tb_yemekAdi.Name = "tb_yemekAdi";
            this.tb_yemekAdi.PasswordChar = '\0';
            this.tb_yemekAdi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_yemekAdi.SelectedText = "";
            this.tb_yemekAdi.SelectionLength = 0;
            this.tb_yemekAdi.SelectionStart = 0;
            this.tb_yemekAdi.ShortcutsEnabled = true;
            this.tb_yemekAdi.Size = new System.Drawing.Size(325, 23);
            this.tb_yemekAdi.TabIndex = 3;
            this.tb_yemekAdi.UseSelectable = true;
            this.tb_yemekAdi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_yemekAdi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Yemek Adı:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(0, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(96, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Yemek Ekle";
            // 
            // menuOlustur
            // 
            this.menuOlustur.Controls.Add(this.metroPanel2);
            this.menuOlustur.Controls.Add(this.panel1);
            this.menuOlustur.HorizontalScrollbarBarColor = true;
            this.menuOlustur.HorizontalScrollbarHighlightOnWheel = false;
            this.menuOlustur.HorizontalScrollbarSize = 10;
            this.menuOlustur.Location = new System.Drawing.Point(4, 38);
            this.menuOlustur.Name = "menuOlustur";
            this.menuOlustur.Size = new System.Drawing.Size(426, 327);
            this.menuOlustur.TabIndex = 2;
            this.menuOlustur.Text = "Menü Oluştur";
            this.menuOlustur.VerticalScrollbarBarColor = true;
            this.menuOlustur.VerticalScrollbarHighlightOnWheel = false;
            this.menuOlustur.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.btn_devam);
            this.metroPanel2.Controls.Add(this.pictureBox2);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Controls.Add(this.lb_selectedList);
            this.metroPanel2.Controls.Add(this.lb_dbList);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 64);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(426, 263);
            this.metroPanel2.TabIndex = 3;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // btn_devam
            // 
            this.btn_devam.Location = new System.Drawing.Point(176, 221);
            this.btn_devam.Name = "btn_devam";
            this.btn_devam.Size = new System.Drawing.Size(75, 23);
            this.btn_devam.TabIndex = 6;
            this.btn_devam.Text = "Devam";
            this.btn_devam.UseSelectable = true;
            this.btn_devam.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::YEMEK_PROGRAMI.Properties.Resources.right_arrow_icon;
            this.pictureBox2.Location = new System.Drawing.Point(196, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YEMEK_PROGRAMI.Properties.Resources.left_arrow_icon;
            this.pictureBox1.Location = new System.Drawing.Point(196, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lb_selectedList
            // 
            this.lb_selectedList.FormattingEnabled = true;
            this.lb_selectedList.Location = new System.Drawing.Point(268, 6);
            this.lb_selectedList.Name = "lb_selectedList";
            this.lb_selectedList.Size = new System.Drawing.Size(120, 238);
            this.lb_selectedList.TabIndex = 3;
            // 
            // lb_dbList
            // 
            this.lb_dbList.FormattingEnabled = true;
            this.lb_dbList.Location = new System.Drawing.Point(36, 6);
            this.lb_dbList.Name = "lb_dbList";
            this.lb_dbList.Size = new System.Drawing.Size(120, 238);
            this.lb_dbList.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.metroLabel6);
            this.panel1.Controls.Add(this.metroLabel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 64);
            this.panel1.TabIndex = 2;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(262, 20);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(138, 25);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Seçilen Yemekler";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(31, 20);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(110, 25);
            this.metroLabel5.TabIndex = 0;
            this.metroLabel5.Text = "Yemek Listesi";
            // 
            // menuDuzenle
            // 
            this.menuDuzenle.Controls.Add(this.menuListesi);
            this.menuDuzenle.Controls.Add(this.metroLabel7);
            this.menuDuzenle.HorizontalScrollbarBarColor = true;
            this.menuDuzenle.HorizontalScrollbarHighlightOnWheel = false;
            this.menuDuzenle.HorizontalScrollbarSize = 10;
            this.menuDuzenle.Location = new System.Drawing.Point(4, 38);
            this.menuDuzenle.Name = "menuDuzenle";
            this.menuDuzenle.Size = new System.Drawing.Size(426, 327);
            this.menuDuzenle.TabIndex = 3;
            this.menuDuzenle.Text = "Menü Düzenleme";
            this.menuDuzenle.VerticalScrollbarBarColor = true;
            this.menuDuzenle.VerticalScrollbarHighlightOnWheel = false;
            this.menuDuzenle.VerticalScrollbarSize = 10;
            // 
            // menuListesi
            // 
            this.menuListesi.AllowUserToResizeRows = false;
            this.menuListesi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuListesi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.menuListesi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.menuListesi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuListesi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.menuListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuListesi.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuListesi.DefaultCellStyle = dataGridViewCellStyle6;
            this.menuListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuListesi.EnableHeadersVisualStyles = false;
            this.menuListesi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.menuListesi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuListesi.Location = new System.Drawing.Point(0, 25);
            this.menuListesi.Name = "menuListesi";
            this.menuListesi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuListesi.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.menuListesi.RowHeadersVisible = false;
            this.menuListesi.RowHeadersWidth = 70;
            this.menuListesi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.menuListesi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuListesi.Size = new System.Drawing.Size(426, 302);
            this.menuListesi.TabIndex = 6;
            this.menuListesi.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuListesi_CellDoubleClick);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(0, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 25);
            this.metroLabel7.TabIndex = 4;
            this.metroLabel7.Text = "Menü Listesi";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.btn_kaydetAyarlar);
            this.metroTabPage1.Controls.Add(this.tb_des2);
            this.metroTabPage1.Controls.Add(this.tb_des1);
            this.metroTabPage1.Controls.Add(this.tb_tamTabak);
            this.metroTabPage1.Controls.Add(this.tb_azTabak);
            this.metroTabPage1.Controls.Add(this.tb_company);
            this.metroTabPage1.Controls.Add(this.tb_phone);
            this.metroTabPage1.Controls.Add(this.metroLabel13);
            this.metroTabPage1.Controls.Add(this.metroLabel12);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(426, 327);
            this.metroTabPage1.TabIndex = 4;
            this.metroTabPage1.Text = "Ayarlar";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.Location = new System.Drawing.Point(81, 150);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(98, 25);
            this.metroLabel13.TabIndex = 13;
            this.metroLabel13.Text = "Açıklama 2:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel12.Location = new System.Drawing.Point(81, 120);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(95, 25);
            this.metroLabel12.TabIndex = 12;
            this.metroLabel12.Text = "Açıklama 1:";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel11.Location = new System.Drawing.Point(-1, 90);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(177, 25);
            this.metroLabel11.TabIndex = 11;
            this.metroLabel11.Text = "Tam Aşçı Tabağı Fiyatı:";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.Location = new System.Drawing.Point(10, 60);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(166, 25);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Az Aşçı Tabağı Fiyatı:";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.Location = new System.Drawing.Point(50, 30);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(126, 25);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "İş yeri telefonu:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(89, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(87, 25);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "İş yeri adı:";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(182, 35);
            this.tb_phone.Mask = "0(999) 000 00 00";
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(118, 20);
            this.tb_phone.TabIndex = 15;
            // 
            // tb_company
            // 
            // 
            // 
            // 
            this.tb_company.CustomButton.Image = null;
            this.tb_company.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tb_company.CustomButton.Name = "";
            this.tb_company.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_company.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_company.CustomButton.TabIndex = 1;
            this.tb_company.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_company.CustomButton.UseSelectable = true;
            this.tb_company.CustomButton.Visible = false;
            this.tb_company.Lines = new string[0];
            this.tb_company.Location = new System.Drawing.Point(182, 2);
            this.tb_company.MaxLength = 32767;
            this.tb_company.Name = "tb_company";
            this.tb_company.PasswordChar = '\0';
            this.tb_company.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_company.SelectedText = "";
            this.tb_company.SelectionLength = 0;
            this.tb_company.SelectionStart = 0;
            this.tb_company.ShortcutsEnabled = true;
            this.tb_company.Size = new System.Drawing.Size(118, 23);
            this.tb_company.TabIndex = 14;
            this.tb_company.UseSelectable = true;
            this.tb_company.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_company.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_azTabak
            // 
            // 
            // 
            // 
            this.tb_azTabak.CustomButton.Image = null;
            this.tb_azTabak.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tb_azTabak.CustomButton.Name = "";
            this.tb_azTabak.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_azTabak.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_azTabak.CustomButton.TabIndex = 1;
            this.tb_azTabak.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_azTabak.CustomButton.UseSelectable = true;
            this.tb_azTabak.CustomButton.Visible = false;
            this.tb_azTabak.Lines = new string[0];
            this.tb_azTabak.Location = new System.Drawing.Point(182, 62);
            this.tb_azTabak.MaxLength = 32767;
            this.tb_azTabak.Name = "tb_azTabak";
            this.tb_azTabak.PasswordChar = '\0';
            this.tb_azTabak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_azTabak.SelectedText = "";
            this.tb_azTabak.SelectionLength = 0;
            this.tb_azTabak.SelectionStart = 0;
            this.tb_azTabak.ShortcutsEnabled = true;
            this.tb_azTabak.Size = new System.Drawing.Size(118, 23);
            this.tb_azTabak.TabIndex = 16;
            this.tb_azTabak.UseSelectable = true;
            this.tb_azTabak.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_azTabak.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_azTabak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azTabak_KeyPress);
            // 
            // tb_tamTabak
            // 
            // 
            // 
            // 
            this.tb_tamTabak.CustomButton.Image = null;
            this.tb_tamTabak.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tb_tamTabak.CustomButton.Name = "";
            this.tb_tamTabak.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_tamTabak.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_tamTabak.CustomButton.TabIndex = 1;
            this.tb_tamTabak.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_tamTabak.CustomButton.UseSelectable = true;
            this.tb_tamTabak.CustomButton.Visible = false;
            this.tb_tamTabak.Lines = new string[0];
            this.tb_tamTabak.Location = new System.Drawing.Point(182, 92);
            this.tb_tamTabak.MaxLength = 32767;
            this.tb_tamTabak.Name = "tb_tamTabak";
            this.tb_tamTabak.PasswordChar = '\0';
            this.tb_tamTabak.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_tamTabak.SelectedText = "";
            this.tb_tamTabak.SelectionLength = 0;
            this.tb_tamTabak.SelectionStart = 0;
            this.tb_tamTabak.ShortcutsEnabled = true;
            this.tb_tamTabak.Size = new System.Drawing.Size(118, 23);
            this.tb_tamTabak.TabIndex = 17;
            this.tb_tamTabak.UseSelectable = true;
            this.tb_tamTabak.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_tamTabak.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_tamTabak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_azTabak_KeyPress);
            // 
            // tb_des1
            // 
            // 
            // 
            // 
            this.tb_des1.CustomButton.Image = null;
            this.tb_des1.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tb_des1.CustomButton.Name = "";
            this.tb_des1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_des1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_des1.CustomButton.TabIndex = 1;
            this.tb_des1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_des1.CustomButton.UseSelectable = true;
            this.tb_des1.CustomButton.Visible = false;
            this.tb_des1.Lines = new string[0];
            this.tb_des1.Location = new System.Drawing.Point(182, 122);
            this.tb_des1.MaxLength = 32767;
            this.tb_des1.Name = "tb_des1";
            this.tb_des1.PasswordChar = '\0';
            this.tb_des1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_des1.SelectedText = "";
            this.tb_des1.SelectionLength = 0;
            this.tb_des1.SelectionStart = 0;
            this.tb_des1.ShortcutsEnabled = true;
            this.tb_des1.Size = new System.Drawing.Size(118, 23);
            this.tb_des1.TabIndex = 18;
            this.tb_des1.UseSelectable = true;
            this.tb_des1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_des1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_des2
            // 
            // 
            // 
            // 
            this.tb_des2.CustomButton.Image = null;
            this.tb_des2.CustomButton.Location = new System.Drawing.Point(96, 1);
            this.tb_des2.CustomButton.Name = "";
            this.tb_des2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_des2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_des2.CustomButton.TabIndex = 1;
            this.tb_des2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_des2.CustomButton.UseSelectable = true;
            this.tb_des2.CustomButton.Visible = false;
            this.tb_des2.Lines = new string[0];
            this.tb_des2.Location = new System.Drawing.Point(182, 152);
            this.tb_des2.MaxLength = 32767;
            this.tb_des2.Name = "tb_des2";
            this.tb_des2.PasswordChar = '\0';
            this.tb_des2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_des2.SelectedText = "";
            this.tb_des2.SelectionLength = 0;
            this.tb_des2.SelectionStart = 0;
            this.tb_des2.ShortcutsEnabled = true;
            this.tb_des2.Size = new System.Drawing.Size(118, 23);
            this.tb_des2.TabIndex = 19;
            this.tb_des2.UseSelectable = true;
            this.tb_des2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_des2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btn_kaydetAyarlar
            // 
            this.btn_kaydetAyarlar.Location = new System.Drawing.Point(225, 192);
            this.btn_kaydetAyarlar.Name = "btn_kaydetAyarlar";
            this.btn_kaydetAyarlar.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydetAyarlar.TabIndex = 20;
            this.btn_kaydetAyarlar.Text = "Kaydet";
            this.btn_kaydetAyarlar.UseSelectable = true;
            this.btn_kaydetAyarlar.Click += new System.EventHandler(this.btn_kaydetAyarlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 452);
            this.Controls.Add(this.mainTab);
            this.Name = "Form1";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "YEMEK PROGRAMI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainTab.ResumeLayout(false);
            this.Anasayfa.ResumeLayout(false);
            this.Anasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yemekListesi)).EndInit();
            this.yemekEkleTab.ResumeLayout(false);
            this.yemekEkleTab.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.menuOlustur.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuDuzenle.ResumeLayout(false);
            this.menuDuzenle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTab;
        private MetroFramework.Controls.MetroTabPage Anasayfa;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage yemekEkleTab;
        private MetroFramework.Controls.MetroGrid yemekListesi;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btn_yemekKayit;
        private MetroFramework.Controls.MetroTextBox tb_fiyat;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox tb_yemekAdi;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private MetroFramework.Controls.MetroTabPage menuOlustur;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private System.Windows.Forms.ListBox lb_selectedList;
        private System.Windows.Forms.ListBox lb_dbList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton btn_devam;
        private MetroFramework.Controls.MetroTabPage menuDuzenle;
        private MetroFramework.Controls.MetroGrid menuListesi;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private System.Windows.Forms.MaskedTextBox tb_phone;
        private MetroFramework.Controls.MetroTextBox tb_des2;
        private MetroFramework.Controls.MetroTextBox tb_des1;
        private MetroFramework.Controls.MetroTextBox tb_tamTabak;
        private MetroFramework.Controls.MetroTextBox tb_azTabak;
        private MetroFramework.Controls.MetroTextBox tb_company;
        private MetroFramework.Controls.MetroButton btn_kaydetAyarlar;
    }
}

