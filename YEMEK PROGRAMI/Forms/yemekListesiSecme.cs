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

namespace YEMEK_PROGRAMI.Forms
{
    public partial class yemekListesiSecme : MetroFramework.Forms.MetroForm
    {
        public Yemekler Secilen { get; private set; } 
        public yemekListesiSecme()
        {
            InitializeComponent();
            using(MyContext context = new MyContext())
            {
                var yemekler = context.Yemek.ToList();
                db_yemekList.DataSource = (yemekler);
            }
        }

        private void db_yemekList_DoubleClick(object sender, EventArgs e)
        {
            Secilen = (Yemekler)db_yemekList.SelectedValue;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
