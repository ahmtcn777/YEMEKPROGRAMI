using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YEMEK_PROGRAMI.Context;
using YEMEK_PROGRAMI.Entity;

namespace YEMEK_PROGRAMI.Forms
{
    public partial class EditYemek : MetroForm
    {
        string _yemekAdi;
        int _id;
        public EditYemek(int id, string yemekAdi)
        {
            _yemekAdi = yemekAdi;
            _id = id;
            InitializeComponent();
            this.Text = _yemekAdi;
            using(MyContext context = new MyContext())
            {
                var yemek = context.Yemek.FirstOrDefault(m => m.Id == _id);
                tb_yemekAdi.Text = yemek.YemekAdi;
                tb_fiyat.Text = yemek.Fiyat.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            //Yemekler yemek = new Yemekler();
            //yemek.Id = _id;
            //yemek.YemekAdi = tb_yemekAdi.Text;
            //yemek.Fiyat = Convert.ToDouble(tb_fiyat.Text);
            //yemek.Status = 1;
            //MyContext context = new MyContext();
            //context.Entry(yemek).State = EntityState.Modified;

            using(MyContext context = new MyContext())
            {
                var yemek = context.Yemek.FirstOrDefault(m => m.Id == _id);
                yemek.YemekAdi = tb_yemekAdi.Text;
                yemek.Fiyat = Convert.ToDouble(tb_fiyat.Text);
                context.SaveChanges();
            }
            MetroMessageBox.Show(this, tb_yemekAdi.Text + " başarıyla kaydedilmiştir.", "Kaydedildi!", MessageBoxButtons.OK, MessageBoxIcon.Question);
            this.Close();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if(MetroMessageBox.Show(this,"Silmek istediğinizden emin misiniz?",_yemekAdi,MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.OK)
            {
                using (MyContext context = new MyContext())
                {
                    var yemek = context.Yemek.FirstOrDefault(m => m.Id == _id);
                    yemek.Status = 0;
                    context.SaveChanges();
                    this.Close();
                }
            }
        }
    }
}
