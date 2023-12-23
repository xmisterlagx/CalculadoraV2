using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraV2
{
    public partial class FDIVISION : Form
    {
        public FDIVISION()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            try
            {
                OPERACIONES operaciones = new OPERACIONES();
                float da = float.Parse(textBox1.Text);
                float db = float.Parse(textBox2.Text);
                float dr = operaciones.Division(da, db);
                textBox3.Text = dr.ToString();
            }
            catch(FormatException)
            {
                MessageBox.Show("Por favor Ingrese Numeros Validos");
            }
        }
    }
}
