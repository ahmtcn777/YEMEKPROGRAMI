using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YEMEK_PROGRAMI.Context;
using YEMEK_PROGRAMI.Entity;
using Menu = YEMEK_PROGRAMI.Entity.Menu;

namespace YEMEK_PROGRAMI.Forms
{
    public partial class MenuOlustur : MetroForm
    {
        ListBox.ObjectCollection _selectedItems = null;
        int kontrol = -1; //1 ise menu olusturdan giris 2 ise menu düzenlemeden giris
        int _id;
        public MenuOlustur(ListBox.ObjectCollection selectedItems)
        {
            _selectedItems = selectedItems;
            InitializeComponent();
            this.Text = "";
            lb_secilen.Items.AddRange(_selectedItems);
            kontrol = 1;
            pb_print.Visible = false;
            metroButton1.Visible = false;
        }

        public MenuOlustur(int id)
        {
            _id = id;
            InitializeComponent();
            btn_kaydet.Visible = false;
            using (MyContext context = new MyContext())
            {
                var menuic = context.MenuIc.Where(m => m.MenuId == _id && m.Status == 1).ToList();
                var menudis = context.MenuDis.Where(m => m.MenuId == _id && m.Status == 1).ToList();
                foreach (var item in menudis)
                {
                    if (context.Yemek.Where(m => m.Id == item.YemekId && m.Status == 1).FirstOrDefault() != null)
                    {
                        var yemek = context.Yemek.Where(m => m.Id == item.YemekId && m.Status == 1).FirstOrDefault();
                        lb_dis.Items.Add(yemek);
                    }
                }

                foreach (var item in menuic)
                {
                    if (context.Yemek.Where(m => m.Id == item.YemekId && m.Status == 1).FirstOrDefault() != null)
                    {
                        var yemek = context.Yemek.Where(m => m.Id == item.YemekId && m.Status == 1).FirstOrDefault();
                        lb_secilen.Items.Add(yemek);
                    }
                }
            }
            kontrol = 2;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (kontrol == 1)
            {
                if (lb_dis.Items.Count < 2)
                {
                    if (lb_secilen.SelectedItems.Count != 0)
                    {
                        bool found = false;
                        var item = lb_secilen.SelectedItem;
                        foreach (var listitem in lb_dis.Items)
                        {
                            if (listitem.Equals(item))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found == false)
                        {
                            lb_secilen.Items.RemoveAt(lb_secilen.SelectedIndex);
                            lb_dis.Items.Add(item);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Menü dışı yemeklerde en fazla 2 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (kontrol == 2)
            {
                if (lb_dis.Items.Count < 2)
                {
                    if (lb_secilen.SelectedItems.Count != 0)
                    {
                        var item = (Yemekler)lb_secilen.SelectedItem;
                        using (MyContext context = new MyContext())
                        {
                            var menuic = context.MenuIc.FirstOrDefault(m => m.YemekId == item.Id);
                            menuic.Status = 0;
                            context.SaveChanges();
                        }
                        using (MyContext context = new MyContext())
                        {
                            if (context.MenuDis.FirstOrDefault(m => m.MenuId == _id && m.YemekId == item.Id) == null)
                            {
                                MenuDis menudis = new MenuDis();
                                menudis.MenuId = _id;
                                menudis.YemekId = item.Id;
                                menudis.Status = 1;
                                context.MenuDis.Add(menudis);
                                context.SaveChanges();
                            }
                            else
                            {
                                var menudis = context.MenuDis.FirstOrDefault(m => m.MenuId == _id && m.YemekId == item.Id);
                                menudis.Status = 1;
                                context.SaveChanges();
                            }
                        }
                        lb_dis.Items.Add(item);
                        lb_secilen.Items.RemoveAt(lb_secilen.SelectedIndex);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Menü dışı yemeklerde en fazla 2 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (kontrol == 1)
            {
                if (lb_secilen.Items.Count < 12)
                {
                    if (lb_dis.SelectedItems.Count != 0)
                    {
                        bool found = false;
                        var item = lb_dis.SelectedItem;
                        foreach (var listitem in lb_secilen.Items)
                        {
                            if (listitem.Equals(item))
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found == false)
                        {
                            lb_dis.Items.RemoveAt(lb_dis.SelectedIndex);
                            lb_secilen.Items.Add(item);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Karşıda zaten mevcut. Listeden kaldırıldı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lb_dis.Items.RemoveAt(lb_dis.SelectedIndex);
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Menüde en fazla 12 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (kontrol == 2)
            {
                if (lb_secilen.Items.Count < 12)
                {
                    if (lb_dis.SelectedItems.Count != 0)
                    {
                        var item = (Yemekler)lb_dis.SelectedItem;
                        using (MyContext context = new MyContext())
                        {
                            var menudis = context.MenuDis.FirstOrDefault(m => m.MenuId == _id && m.YemekId == item.Id);
                            menudis.Status = 0;
                            context.SaveChanges();
                        }
                        using (MyContext context = new MyContext())
                        {
                            if (context.MenuIc.FirstOrDefault(m => m.MenuId == _id && m.YemekId == item.Id) == null)
                            {
                                MenuIc menuic = new MenuIc();
                                menuic.MenuId = _id;
                                menuic.YemekId = item.Id;
                                menuic.Status = 1;
                                context.MenuIc.Add(menuic);
                                context.SaveChanges();
                            }
                            else
                            {
                                var menuic = context.MenuIc.FirstOrDefault(m => m.YemekId == item.Id);
                                menuic.Status = 1;
                                context.SaveChanges();
                            }
                        }
                        lb_secilen.Items.Add(item);
                        lb_dis.Items.RemoveAt(lb_dis.SelectedIndex);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Menüde en fazla 12 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            using (MyContext context = new MyContext())
            {
                var menuicYemekler = lb_secilen.Items.Cast<Yemekler>();
                var menudisYemekler = lb_dis.Items.Cast<Yemekler>();
                var menu = new Menu();
                menu.Tarih = DateTime.Now;
                context.GunlukMenu.Add(menu);
                context.SaveChanges();
                var menuicList = menuicYemekler.Select(m => new MenuIc { YemekId = m.Id, MenuId = menu.Id, Status = 1 });
                context.MenuIc.AddRange(menuicList);
                var menudisList = menudisYemekler.Select(m => new MenuDis { YemekId = m.Id, MenuId = menu.Id, Status = 1 });
                context.MenuDis.AddRange(menudisList);
                context.SaveChanges();
                _id = menu.Id;

            }
            this.Close();
        }

        private void btn_ekleSecilen_Click(object sender, EventArgs e)
        {
            if (lb_secilen.Items.Count < 12)
            {
                var item = new Forms.yemekListesiSecme();
                bool found = true;
                if (item.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item1 in lb_secilen.Items)
                    {
                        if (item.Secilen.Equals(item1))
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        foreach (var item1 in lb_dis.Items)
                        {
                            if (item.Secilen.Equals(item1))
                            {
                                found = false;
                                break;
                            }
                        }
                    }
                }
                if (found)
                {
                    if (item.Secilen != null)
                    {
                        lb_secilen.Items.Add(item.Secilen);
                        int yemekId = item.Secilen.Id;
                        using (MyContext context = new MyContext())
                        {
                            if (context.MenuIc.Where(m => m.MenuId == _id && m.YemekId == yemekId).FirstOrDefault() == null)
                            {
                                MenuIc menuic = new MenuIc();
                                menuic.MenuId = _id;
                                menuic.YemekId = yemekId;
                                menuic.Status = 1;
                                context.MenuIc.Add(menuic);
                                context.SaveChanges();
                            }
                            else
                            {
                                var menuic = context.MenuIc.FirstOrDefault(m => m.MenuId == _id && m.YemekId == yemekId);
                                menuic.Status = 1;
                                context.SaveChanges();
                            }
                        }
                    }

                }
                else
                    MetroMessageBox.Show(this, "Yemek zaten menüde mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, "Menüde en fazla 12 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_silSecilen_Click(object sender, EventArgs e)
        {
            if (kontrol == 2)
            {
                if (lb_secilen.SelectedItems.Count != 0)
                {
                    using (MyContext context = new MyContext())
                    {
                        var menuic = context.MenuIc.FirstOrDefault(m => m.MenuId == _id && m.YemekId == ((Yemekler)lb_secilen.SelectedItem).Id);
                        menuic.Status = 0;
                        context.SaveChanges();
                    }
                    lb_secilen.Items.Remove(lb_secilen.SelectedItem);

                }
                else
                    MetroMessageBox.Show(this, "Lütfen sileceğiniz yemeği seçiniz.!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kontrol == 1)
            {
                if (lb_secilen.SelectedItems.Count != 0)
                    lb_secilen.Items.Remove(lb_secilen.SelectedItem);
                else
                    MetroMessageBox.Show(this, "Lütfen sileceğiniz yemeği seçiniz.!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ekleDis_Click(object sender, EventArgs e)
        {
            if (lb_dis.Items.Count < 2)
            {
                var item = new Forms.yemekListesiSecme();
                bool found = true;
                if (item.ShowDialog() == DialogResult.OK)
                {
                    foreach (var item1 in lb_dis.Items)
                    {
                        if (item.Secilen.Equals(item1))
                        {
                            found = false;
                            break;
                        }
                    }
                    if (found == true)
                    {
                        foreach (var item1 in lb_secilen.Items)
                        {
                            if (item.Secilen.Equals(item1))
                            {
                                found = false;
                                break;
                            }
                        }
                    }
                }
                if (found)
                {
                    if (item.Secilen != null)
                    {
                        lb_dis.Items.Add(item.Secilen);
                        int yemekId = item.Secilen.Id;
                        using (MyContext context = new MyContext())
                        {
                            if (context.MenuDis.Where(m => m.MenuId == _id && m.YemekId == yemekId).FirstOrDefault() == null)
                            {
                                MenuDis menudis = new MenuDis();
                                menudis.MenuId = _id;
                                menudis.YemekId = yemekId;
                                menudis.Status = 1;
                                context.MenuDis.Add(menudis);
                                context.SaveChanges();
                            }
                            else
                            {
                                var menudis = context.MenuDis.FirstOrDefault(m => m.MenuId == _id && m.YemekId == yemekId);
                                menudis.Status = 1;
                                context.SaveChanges();
                            }
                        }
                    }
                }
                else
                    MetroMessageBox.Show(this, "Yemek zaten menüde mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MetroMessageBox.Show(this, "Menü dışı yemeklerde en fazla 2 yemek olabilir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_silDis_Click(object sender, EventArgs e)
        {
            if (kontrol == 2)
            {
                if (lb_dis.SelectedItems.Count != 0)
                {
                    using (MyContext context = new MyContext())
                    {
                        var menudis = context.MenuDis.FirstOrDefault(m => m.YemekId == ((Yemekler)lb_dis.SelectedItem).Id);
                        menudis.Status = 0;
                        context.SaveChanges();
                    }
                    lb_dis.Items.Remove(lb_dis.SelectedItem);
                }
                else
                    MetroMessageBox.Show(this, "Lütfen sileceğiniz yemeği seçiniz.!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (kontrol == 1)
            {
                if (lb_dis.SelectedItems.Count != 0)
                {
                    lb_dis.Items.Remove(lb_dis.SelectedItem);
                }
                else
                    MetroMessageBox.Show(this, "Lütfen sileceğiniz yemeği seçiniz.!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_print_Click(object sender, EventArgs e)
        {
            print_dialog.ShowDialog();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            print_dialog2.Document.DefaultPageSettings.Landscape = true;
            this.Hide();
            print_dialog2.ShowDialog();
            this.Show();
        }

        private void print_yazici_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using (MyContext context = new MyContext())
            {
                /*SELECT * FROM  menudis
                INNER JOIN yemekler ON yemekler.Id = menudis.YemekId
                WHERE menudis.status =1 AND yemekler.status = 1 AND menudis.menuid = _id
                */
                var menu = context.GunlukMenu.FirstOrDefault(m => m.Id == _id);
                var yemekleric = context.MenuIc.Where(m => m.MenuId == menu.Id && m.Status == 1).Join(context.Yemek, m => m.YemekId, m => m.Id, (m, n) => n).ToList();
                var yemeklerdis = context.MenuDis.Where(m => m.MenuId == menu.Id && m.Status == 1).Join(context.Yemek, m => m.YemekId, m => m.Id, (m, n) => n).ToList();
                var ayarlar = context.Ayarlar.FirstOrDefault();
                SolidBrush solidBrush = new SolidBrush(Color.Black);
                StringFormat baslikFormat = new StringFormat();
                baslikFormat.Alignment = StringAlignment.Center;
                StringFormat yemekFormat = new StringFormat();
                yemekFormat.Alignment = StringAlignment.Near;
                var loc = e.PageBounds;
                e.Graphics.DrawString(ayarlar.Company, new Font("Calibri", 72, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);
                loc.Location = new Point(loc.Location.X, loc.Y + (int)(72 * 1.5));
                e.Graphics.DrawString((menu.Tarih).Date.ToString("dd/MM/yyyy"), new Font("Calibri", 48, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);
                loc.Location = new Point(loc.Location.X, loc.Y + (int)(56 * 1.5));
                e.Graphics.DrawString("GÜNÜN MENÜSÜ", new Font("Calibri", 56, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);
                loc.Location = new Point(loc.Location.X + 60, loc.Y + (int)(75 * 1.5));

                foreach (var item in yemekleric)
                {
                    e.Graphics.DrawString(item.YemekAdi.ToUpper() + " (" + item.Fiyat.ToString() + "TL)", new Font("Calibri", 28, FontStyle.Regular), solidBrush, loc, yemekFormat);
                    loc.Location = new Point(loc.Location.X, loc.Y + (int)(28 * 1.5));
                }
                loc.Location = new Point(loc.Location.X, loc.Y + (int)((13 - yemekleric.Count) * 32 * 1.5));
                if (yemeklerdis.Count != 0)
                {
                    e.Graphics.DrawString("MENÜYE DAHİL DEĞİLDİR", new Font("Calibri", 28, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, yemekFormat);
                }
                loc.Location = new Point(loc.Location.X, loc.Y + (int)(28 * 1.5));
                foreach (var item in yemeklerdis)
                {
                    e.Graphics.DrawString(item.YemekAdi.ToUpper() + " (" + item.Fiyat.ToString() + "TL)", new Font("Calibri", 28, FontStyle.Regular), solidBrush, loc, yemekFormat);
                    loc.Location = new Point(loc.Location.X, loc.Y + (int)(28 * 1.5));
                }
                loc.Location = new Point(loc.Location.X - 60, loc.Y + (int)((2 - yemeklerdis.Count) * 32 * 1.5) + 20);
                e.Graphics.DrawString(ayarlar.Description1 + "\n AZ AŞÇI TABAĞI : " + ayarlar.AzTabak.ToString() + "TL / TAM AŞÇI TABAĞI : " + ayarlar.TamTabak.ToString() + "TL ", new Font("Calibri", 21, FontStyle.Bold), solidBrush, loc, baslikFormat);
                loc.Location = new Point(loc.Location.X, loc.Y + (int)(2 * 21 * 1.75));
                e.Graphics.DrawString(ayarlar.Description2, new Font("Calibri", 16, FontStyle.Bold), solidBrush, loc, baslikFormat);
                loc.Location = new Point(loc.Location.X, loc.Y + (int)(16 * 1.5));
                e.Graphics.DrawString("** AFİYET OLSUN ** TEL : " + ayarlar.Phone, new Font("Calibri", 32, FontStyle.Bold), solidBrush, loc, baslikFormat);

                //e.Graphics.DrawString("GÜNÜN MENÜSÜ", new Font("Calibri", 56, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);
                //e.Graphics.DrawString("GÜNÜN MENÜSÜ", new Font("Calibri", 56, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);
                //e.Graphics.DrawString("GÜNÜN MENÜSÜ", new Font("Calibri", 56, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, baslikFormat);

            }
        }

        private void print_yazici2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var x = (e.PageBounds.Width-20) / 5;
            var y = (e.PageBounds.Height-40 ) / 3;
            Rectangle loc = new Rectangle(20, 20, e.PageBounds.Width / 5-20, e.PageBounds.Height / 3-20);
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    e.Graphics.DrawRectangle(new Pen(new SolidBrush(Color.Black)), loc.Location.X-10, loc.Location.Y, x,y );
                    var ytemp = loc.Location.Y;
                    using (MyContext context = new MyContext())
                    {
                        var menu = context.GunlukMenu.FirstOrDefault(m => m.Id == _id);
                        var yemekleric = context.MenuIc.Where(m => m.MenuId == menu.Id && m.Status == 1).Join(context.Yemek, m => m.YemekId, m => m.Id, (m, n) => n).ToList();
                        var yemeklerdis = context.MenuDis.Where(m => m.MenuId == menu.Id && m.Status == 1).Join(context.Yemek, m => m.YemekId, m => m.Id, (m, n) => n).ToList();
                        var ayarlar = context.Ayarlar.FirstOrDefault();
                        SolidBrush solidBrush = new SolidBrush(Color.Black);
                        StringFormat baslikFormat = new StringFormat();
                        baslikFormat.Alignment = StringAlignment.Center;
                        StringFormat yemekFormat = new StringFormat();
                        yemekFormat.Alignment = StringAlignment.Near;

                        e.Graphics.DrawString(ayarlar.Company + " " + (menu.Tarih).Date.ToString("dd/MM/yyyy"), new Font("Calibri", 10, FontStyle.Bold), solidBrush, loc, yemekFormat);
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(10 * 1.5));
                        e.Graphics.DrawString("GÜNÜN MENÜSÜ", new Font("Calibri", 10, FontStyle.Regular), solidBrush, loc, yemekFormat);
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(10 * 1.5));

                        foreach (var item in yemekleric)
                        {
                            e.Graphics.DrawString(item.YemekAdi.ToUpper() + " (" + item.Fiyat.ToString() + "TL)", new Font("Calibri", 7.5f, FontStyle.Regular), solidBrush, loc, yemekFormat);
                            loc.Location = new Point(loc.Location.X, loc.Y + (int)(7.5f * 1.5));
                        }
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)((13 - yemekleric.Count) * 7.5f * 1.5));
                        if (yemeklerdis.Count != 0)
                        {
                            e.Graphics.DrawString("MENÜYE DAHİL DEĞİLDİR", new Font("Calibri", 7.5f, FontStyle.Bold | FontStyle.Underline), solidBrush, loc, yemekFormat);
                        }
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(7.5f * 1.5));
                        foreach (var item in yemeklerdis)
                        {
                            e.Graphics.DrawString(item.YemekAdi.ToUpper() + " (" + item.Fiyat.ToString() + "TL)", new Font("Calibri", 7.5f, FontStyle.Regular), solidBrush, loc, yemekFormat);
                            loc.Location = new Point(loc.Location.X, loc.Y + (int)(7.5f * 1.5));
                        }
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)((2 - yemeklerdis.Count) * 8 * 1.5));
                        e.Graphics.DrawString(ayarlar.Description1, new Font("Calibri", 6, FontStyle.Bold), solidBrush, loc, yemekFormat);
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(6 * 1.5));
                        e.Graphics.DrawString("AZ AŞÇI TABAĞI : " + ayarlar.AzTabak.ToString() + "TL / TAM AŞÇI TABAĞI : " + ayarlar.TamTabak.ToString() + "TL ", new Font("Calibri", 6, FontStyle.Bold), solidBrush, loc, yemekFormat);
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(6 * 1.5));
                        e.Graphics.DrawString(ayarlar.Description2, new Font("Calibri", 6, FontStyle.Regular), solidBrush, loc, yemekFormat);
                        loc.Location = new Point(loc.Location.X, loc.Y + (int)(6 * 1.5));
                        e.Graphics.DrawString("TEL : " + ayarlar.Phone, new Font("Calibri", 6, FontStyle.Regular), solidBrush, loc, yemekFormat);
                    }
                    loc.Location = new Point(loc.Location.X + x, ytemp);
                }
                loc.Location = new Point(20, loc.Location.Y+y);
            }

        }
    }
}
