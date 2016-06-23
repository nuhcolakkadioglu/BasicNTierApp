using Ntier.ORM.Entity;
using Ntier.ORM.Facede;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ntier.WinFormUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KategoriListele()
        {
            dataGridView1.DataSource = Kategoriler.Select();
            dataGridView1.Columns["KategoriID"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Kategori model = new Kategori();

            model.KategoriAdi = txtAdi.Text;
            model.Tanimi = txtTanim.Text;

          bool sonuc =  Kategoriler.Insert(model);

            if (sonuc)
            {
                MessageBox.Show("kategori Eklendi");
                KategoriListele();
            }
                

          

            else
                MessageBox.Show("hata oluştu");

        }
    }
}
