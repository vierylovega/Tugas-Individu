using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ekspedisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCekTarif f3 = new FormCekTarif();
            f3.Show();
            this.Hide();
        }

        private void bakun_Click(object sender, EventArgs e)
        {

        }

        private void bcustomerservice_Click(object sender, EventArgs e)
        {
            FormCS f7 = new FormCS();
            f7.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bkirimsekarang_Click(object sender, EventArgs e)
        {
            FormKirim f2 = new FormKirim();
            f2.Show();
            this.Hide();
        }

        private void btentangkami_Click(object sender, EventArgs e)
        {
            FormKamiAsli f5 = new FormKamiAsli();
            f5.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void blacakpaket_Click(object sender, EventArgs e)
        {
            FormLacakPaket f6 = new FormLacakPaket();
            f6.Show();
            this.Hide();
        }
    }
}
