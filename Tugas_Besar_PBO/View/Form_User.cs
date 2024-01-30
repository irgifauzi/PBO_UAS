using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_User : Form
    {
        public Form_User()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Diamond FormD = new Form_Diamond();
            FormD.MdiParent = this;
            FormD.Show();
        }

        private void jasaJokiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_jasa Formjs = new Form_jasa();
            Formjs.MdiParent = this;
            Formjs.Show();

        }

        private void diamondDanJasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Diamond_Joki Formp = new Form_Diamond_Joki();
            Formp.MdiParent = this;
            Formp.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }

        private void Form_User_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Data_transaksi Formp = new Data_transaksi();
            Formp.MdiParent = this;
            Formp.Show();
        }
    }
}
