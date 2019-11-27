using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTareas
{
    public partial class Factorial : Form
    {
        
        public Factorial()
        {
            InitializeComponent();
            MessageBox.Show("HOLA MUNDO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (this.textBox1.Text.Length == 0)
            {
                MessageBox.Show("Ingrse algún valor");
                this.textBox1.Focus();
                return;
            }
            num = int.Parse(this.textBox1.Text);
            long fact = facnum(num);
            this.textBox2.Text = fact.ToString();
        }

        private long facnum(int num )
        {
            int cont = 1;
            for (int i = 1; i <= num; i++)
                
            {
                cont = cont * i;
            }
            return cont;

        }

        private void Factorial_Load(object sender, EventArgs e)
        {

        }
    }
}
