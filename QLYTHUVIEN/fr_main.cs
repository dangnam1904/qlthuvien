using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLYTHUVIEN
{
    public partial class fr_main : Form
    {
        public fr_main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Functions.Connect();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void quảnLýĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyDocGia quanLyDocGia = new QuanLyDocGia();
            quanLyDocGia.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_tacgia fr_Tacgia = new fr_tacgia();
            fr_Tacgia.Show();
        }

        private void loaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_loaisach fr_Loaisach = new fr_loaisach();
            fr_Loaisach.Show();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            quanlysach quanlysach = new quanlysach();
            quanlysach.Show();
        }

        private void mượnSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_muon fr_Muon = new fr_muon();
            fr_Muon.Show();
        }

        private void trảSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr_trasach fr_Trasach = new fr_trasach();
            fr_Trasach.Show();
        }
    }
}
