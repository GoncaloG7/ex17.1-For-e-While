using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex17._1_For_e_While
{
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            double numeroMaior = n1;

            double i = n1 + 1;
            while (i <= n2)
            {
                if (i > numeroMaior)
                {
                    numeroMaior = i;
                }
                i++;
            }
            MessageBox.Show("O nº " + numeroMaior + " e o maior");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Form frm in Application.OpenForms)
            {
                frm.Close(); 
            }
        }
    }
}
