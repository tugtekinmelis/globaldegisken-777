using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace global_degisken_777
{
    public partial class Form1 : Form
    {
        //bakiye global değişkendir.
        double bakiye = 200;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBakiye.Text = "Bakiye:" +bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            bakiye = bakiye + 50;
            lblBakiye.Text = "Bakiye:"  +bakiye.ToString();
            lblBakiye.ForeColor = Color.Green;
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(bakiye >= 8)
            {
                bakiye = bakiye - 8;
                lblBakiye.Text = "Öde:" + bakiye.ToString();
            }
            else
            {
                lblBakiye.Text = "FAKİR KAYBOL..";
                lblBakiye.ForeColor = Color.Red;
            } 
        }
    }
}
