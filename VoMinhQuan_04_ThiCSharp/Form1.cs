using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoMinhQuan_04_ThiCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         



        }

        private void label1_Click(object sender, EventArgs e)
        {
            string hovaten = "Võ Minh Quân";
            string mssv = "1223360168";
            string monthi = "Lập Trinh Windows 2 _ C#";

            label1.Text = "Họ Ten :" + hovaten;
            label1.Text += "\nMSSV: " + mssv;
            label1.Text += "\nNgaythi: " + System.DateTime.Now.ToString();
            label1.Text += "\nMonthi: :" + monthi;




        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dinhdang gbt = new Dinhdang();
            gbt.Show();
        }

        private void giảiPhươngTrìnhBật2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Phuongtrinhbat2 gbt = new Phuongtrinhbat2();    
            gbt.Show();
        }
    }
}
