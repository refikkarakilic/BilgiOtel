using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void formuTemizle()
        {
            Form[] formlar = this.MdiChildren;
            for (int k = 0; k < formlar.Length; k++)
                formlar[k].Close();
        }

        private void müşteriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formuTemizle();
            MsteriEkleSorgula musteriekle = new MsteriEkleSorgula();
            musteriekle.MdiParent = this;
            musteriekle.FormBorderStyle = FormBorderStyle.None;
            musteriekle.Show();
            
        }

        private void misafirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formuTemizle();
            MisafirEkeSorgula misafirekle = new MisafirEkeSorgula();
            misafirekle.MdiParent = this;
            misafirekle.FormBorderStyle = FormBorderStyle.None;
            misafirekle.Show();
            
        }

        private void odaSatışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formuTemizle();
            OdaSatis odasatis = new OdaSatis();
            odasatis.MdiParent = this;
            odasatis.FormBorderStyle = FormBorderStyle.None;
            odasatis.Show();
            
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formuTemizle();
            PersonelEkleSorgula personel = new PersonelEkleSorgula();
            personel.MdiParent = this;
            personel.FormBorderStyle = FormBorderStyle.None;
            personel.Show();
            
        }

        private void kampanyaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formuTemizle();
            KampanyaEkleDuzenle kampanya = new KampanyaEkleDuzenle();
            kampanya.MdiParent = this;
            kampanya.FormBorderStyle = FormBorderStyle.None;
            kampanya.Show();
            
        }
    }
}
