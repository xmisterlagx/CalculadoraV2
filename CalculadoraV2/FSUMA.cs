using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculadoraV2;

namespace CalculadoraV2
{
    public partial class FSUMA : Form
    {
        public FSUMA()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                OPERACIONES operaciones = new OPERACIONES();
                float sa = float.Parse(textBox1.Text);
                float sb = float.Parse(textBox2.Text);
                float resultado = operaciones.Suma(sa, sb);
                textBox3.Text = resultado.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresa números válidos");
            }
        }
    }
}
