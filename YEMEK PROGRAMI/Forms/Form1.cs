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

namespace YEMEK_PROGRAMI
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            Listele();
            //var yemekler = (from y in context.Yemek
            //                where y.Status == 1
            //                select new
            //                {
            //                    yemekAdi = y.YemekAdi,
            //                    fiyat = y.Fiyat
            //                }).ToList();
            yemekListesi.Columns[0].Visible = false;
            yemekListesi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yemekListesi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            yemekListesi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            yemekListesi.MultiSelect = false;
            this.yemekListesi.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            menuListesi.Columns[0].Visible = false;
            menuListesi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            menuListesi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            menuListesi.MultiSelect = false;

        }
        private void mainTab_Selected(object sender, TabControlEventArgs e)
        {
            Listele();

        }

        public void Listele()
        {
            using(MyContext context = new MyContext())
            {
                var yemekler = context.Yemek.Where(s => s.Status == 1).Select(yemek => new { Id = yemek.Id, YemekAdı = yemek.YemekAdi, Fiyat = yemek.Fiyat + " TL" }).ToList();
                yemekListesi.DataSource = yemekler;
            }
            using (MyContext context = new MyContext())
            {
                lb_dbList.Items.Clear();
                var yemekler1 = context.Yemek.Where(s => s.Status == 1).ToList();
                lb_dbList.Items.AddRange(yemekler1.ToArray());
                //lb_dbList.DataSource = yemekler;
            }
            using (MyContext context = new MyContext())
            {
                var menuler = context.GunlukMenu.OrderByDescending(gunlukmenu => gunlukmenu.Tarih).Select(gunlukmenu => new { Id = gunlukmenu.Id, Tarih = gunlukmenu.Tarih }).ToList();
                menuListesi.DataSource = menuler;
            }
            using(MyContext context = new MyContext())
            {
                var ayarlar = context.Ayarlar.FirstOrDefault();
                tb_company.Text = ayarlar.Company;
                tb_phone.Text = ayarlar.Phone;
                tb_azTabak.Text = ayarlar.AzTabak.ToString();
                tb_tamTabak.Text = ayarlar.TamTabak.ToString();
                tb_des1.Text = ayarlar.Description1;
                tb_des2.Text = ayarlar.Description2;
            }
            //MyContext context = new MyContext();
            //var yemekler = context.Yemek.Select(yemek => new { Id = yemek.Id, YemekAdı = yemek.YemekAdi, Fiyat = yemek.Fiyat + " TL" }).ToList();
            //yemekListesi.DataSource = yemekler;
        }

        private void btn_yemekKayit_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if(string.IsNullOrEmpty(tb_yemekAdi.Text) || string.IsNullOrEmpty(tb_fiyat.Text))
            {
                if (string.IsNullOrEmpty(tb_yemekAdi.Text))
                {
                    errorProvider.SetError(tb_yemekAdi, "Bu alan boş bırakılamaz");
                }
                if (string.IsNullOrEmpty(tb_fiyat.Text))
                {
                    errorProvider.SetError(tb_fiyat, "Bu alan boş bırakılamaz");
                }
            }
            else
            {
                using(MyContext context = new MyContext())
                {
                    if(context.Yemek.FirstOrDefault(m => m.YemekAdi == tb_yemekAdi.Text) == null)
                    {
                        Yemekler yemek = new Yemekler();
                        yemek.YemekAdi = tb_yemekAdi.Text;
                        yemek.Fiyat = Convert.ToDouble(tb_fiyat.Text);
                        yemek.Status = 1;
                        context.Yemek.Add(yemek);
                        context.SaveChanges();
                    }
                    else
                    {
                        var item = context.Yemek.FirstOrDefault(m => m.YemekAdi == tb_yemekAdi.Text);
                        item.Status = 1;
                        item.Fiyat = Convert.ToDouble(tb_fiyat.Text);
                        context.SaveChanges();
                    }
                }

                //Yemekler yemek = new Yemekler();
                //yemek.YemekAdi = tb_yemekAdi.Text;
                //yemek.Fiyat = Convert.ToDouble(tb_fiyat.Text);
                //yemek.Status = 1;
                //MyContext context = new MyContext();
                //context.Yemek.Add(yemek);
                //context.SaveChanges();
                MetroMessageBox.Show(this, tb_yemekAdi.Text + " başarıyla kaydedilmiştir.", "Kaydedildi!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                tb_yemekAdi.Clear();
                tb_fiyat.Clear();
            }
        }

        private void tb_fiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void yemekListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string yemekAdi;
            int yemekId;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = yemekListesi.Rows[rowIndex];
            yemekAdi = row.Cells[1].Value.ToString();
            yemekId = Convert.ToInt32(row.Cells[0].Value);
            this.Hide();
            new Forms.EditYemek(yemekId, yemekAdi).ShowDialog();
            Listele();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(lb_dbList.SelectedItems.Count != 0)
            {
                var item = lb_dbList.SelectedItem;
                lb_dbList.Items.RemoveAt(lb_dbList.SelectedIndex);
                lb_selectedList.Items.Add(item);
            }
            else
            {
                MetroMessageBox.Show(this," Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lb_selectedList.SelectedItems.Count != 0)
            {
                var item = lb_selectedList.SelectedItem;
                lb_selectedList.Items.RemoveAt(lb_selectedList.SelectedIndex);
                lb_dbList.Items.Add(item);
            }
            else
            {
                MetroMessageBox.Show(this, "Lütfen yemek seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            using(MyContext context = new MyContext())
            {
                var time = DateTime.Now.Date;
                var menu1 = context.GunlukMenu.FirstOrDefault(t => t.Tarih == time);
                if (menu1 == null)
                {
                    if (lb_selectedList.Items.Count != 0)
                    {
                        var selectedItems = lb_selectedList.Items;
                        this.Hide();
                        new Forms.MenuOlustur(selectedItems).ShowDialog();
                        lb_selectedList.Items.Clear();
                        Listele();
                        this.Show();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Onaylamadan önce en az bir tane yemek seçmelisiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Bugün zaten menü oluşturmuşsunuz. Lütfen menü düzenlemeyi kullanınız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void menuListesi_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int menuId;
            int rowIndex = e.RowIndex;
            DataGridViewRow row = menuListesi.Rows[rowIndex];
            menuId = Convert.ToInt32(row.Cells[0].Value);
            this.Hide();
            new Forms.MenuOlustur(menuId).ShowDialog();
            Listele();
            this.Show();
        }

        private void btn_kaydetAyarlar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(tb_company.Text) || 
                string.IsNullOrEmpty(tb_phone.Text) ||
                string.IsNullOrEmpty(tb_azTabak.Text) ||
                string.IsNullOrEmpty(tb_tamTabak.Text) ||
                string.IsNullOrEmpty(tb_des1.Text) ||
                string.IsNullOrEmpty(tb_des2.Text))
            {
                if (string.IsNullOrEmpty(tb_company.Text))
                {
                    errorProvider.SetError(tb_company, "Bu alan boş bırakılamaz");
                }
                if (tb_phone.Text.Length <= 10)
                {
                    errorProvider.SetError(tb_phone, "Telefon numarasını 10 hane olacak şekilde yazınız");
                }
                if (string.IsNullOrEmpty(tb_azTabak.Text))
                {
                    errorProvider.SetError(tb_azTabak, "Bu alan boş bırakılamaz");
                }
                if (string.IsNullOrEmpty(tb_tamTabak.Text))
                {
                    errorProvider.SetError(tb_tamTabak, "Bu alan boş bırakılamaz");
                }
                if (string.IsNullOrEmpty(tb_des1.Text))
                {
                    errorProvider.SetError(tb_des1, "Bu alan boş bırakılamaz");
                }
                if (string.IsNullOrEmpty(tb_des2.Text))
                {
                    errorProvider.SetError(tb_des2, "Bu alan boş bırakılamaz");
                }
            }
            else
            {
                using(MyContext context = new MyContext())
                {
                    var item = context.Ayarlar.FirstOrDefault();
                    item.Company = tb_company.Text;
                    item.Phone = tb_phone.Text;
                    item.AzTabak = Convert.ToDouble(tb_azTabak.Text);
                    item.TamTabak = Convert.ToDouble(tb_tamTabak.Text);
                    item.Description1 = tb_des1.Text;
                    item.Description2 = tb_des2.Text;
                    context.SaveChanges();
                    MetroMessageBox.Show(this, "Ayarlarınız kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }

        private void tb_azTabak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}
