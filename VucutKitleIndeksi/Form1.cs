using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VucutKitleIndeksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, oran;
            boy = Convert.ToDouble(txtboy.Text);
            kilo = Convert.ToDouble(txtkilo.Text);
            oran = kilo / (boy * boy);
            txtoran.Text = oran.ToString();
            if (oran < 18)
            {
                txtsonuc.Text = "Zayıf";
            }
            else if (oran >= 18 && oran < 25)
            {
                txtsonuc.Text = "Normal";
            }
            else if (oran >= 25 && oran < 30)
            {
                txtsonuc.Text = "Kilolu";
            }
            else if (oran >= 30 && oran < 35)
            {
                txtsonuc.Text = "Obez";
            }
            else
            {
                txtsonuc.Text = "Ciddi Obez";
            }
        }
    }
}
