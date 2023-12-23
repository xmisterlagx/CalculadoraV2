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
    public partial class FMULTIPLICACION : Form
    {
        public FMULTIPLICACION()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            OPERACIONES operaciones = new OPERACIONES();
            float ma = float.Parse(textBox1.Text);
            float mb = float.Parse(textBox2.Text);
            float mr = operaciones.Multiplicacion(ma, mb);
            textBox3.Text = mr.ToString();
        }
    }
}
