using System.Runtime.Serialization;

namespace ex17._1_For_e_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            this.Hide();
            f3.Show();
        }

        private void btnCiclo_Click(object sender, EventArgs e)
        {
            double n1 = Convert.ToDouble(textBox1.Text);
            double n2 = Convert.ToDouble(textBox2.Text);
            double numeroMaior = n1;

            for (double i = n1 + 1; i <= n2; i++)
            {
                if (i > numeroMaior)
                {
                    numeroMaior = i;
                }
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
