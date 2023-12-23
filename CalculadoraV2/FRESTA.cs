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
    public partial class FRESTA : Form
    {
        public FRESTA()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            OPERACIONES operaciones = new OPERACIONES();
            float ra = float.Parse(textBox1.Text);
            float rb = float.Parse(textBox2.Text);
            float rr= operaciones.Resta(ra, rb);
            textBox3.Text = rr.ToString();
        }
    }
}
