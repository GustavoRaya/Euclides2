using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facciones_Continuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int m, n;
            m = int.Parse(Txtm.Text);
            n = int.Parse(Txtn.Text);
            TbDatos.Rows.Clear();

            MCD(m, n);
        }

        private void MCD(int m, int n)
        {
            if (n == 0)
                return;

            int div = m / n;
            int remainder = m % n;

            string ec;
            if (remainder == 0)
            {
                ec = m + "/" + n + " = " + div;
            }
            else
            {
                ec= m + "/" + n + " = " + div + " + 1/" + n + " / " + remainder;
            }

            TbDatos.Rows.Add(TbDatos.Rows.Count, m + " dividido entre " + n + " es " + div + " y sobran " + remainder, ec);

            
            MCD(n, remainder);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Txtm.Text = "";
            Txtn.Text = "";
            TbDatos.Rows.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click_1(object sender, EventArgs e)
        {
            Txtm.Text = "";
            Txtn.Text = "";
            TbDatos.Rows.Clear();
        }
    }
}
