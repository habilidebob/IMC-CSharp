using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCUC12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double p, a, imc;
            p = double.Parse(txtPeso.Text);
            a = double.Parse(txtAltura.Text);
            imc = p / (a * a);
            txtIMC.Text = Math.Round(imc, 2).ToString();


        }
    }
}
