using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class Data_transaksi : Form
    {
        public Data_transaksi()
        {
            InitializeComponent();
        }
        Koneksi koneksi = new Koneksi();
        M_DataDiamond m_DataDiamond = new M_DataDiamond();
        string id_diamond;

        public void Tampil()
        {
            datatransaksi.DataSource = koneksi.ShowData("SELECT * FROM t_diamond");
            datatransaksi.Columns[0].HeaderText = "ID_user";
            datatransaksi.Columns[1].HeaderText = "id_server";
            datatransaksi.Columns[2].HeaderText = "jumlah_diamond";
            datatransaksi.Columns[3].HeaderText = "harga";
            datatransaksi.Columns[4].HeaderText = "email";
            datatransaksi.Columns[5].HeaderText = "metode_pembayaran";


        }
        public void Tampiljoki()
        {
            datatransaksi.DataSource = koneksi.ShowData("SELECT * FROM t_jasa_joki");
            datatransaksi.Columns[0].HeaderText = "ID_Diamond";
            datatransaksi.Columns[1].HeaderText = "Jumlah_Diamond";
            datatransaksi.Columns[2].HeaderText = "Bonus_Diamond";
            datatransaksi.Columns[3].HeaderText = "Harga_Diamond";


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_transaksi_Load(object sender, EventArgs e)
        {
           
                
           
        }
    }
}
