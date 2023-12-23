namespace CalculadoraV2
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                var fsuma = new FSUMA();
                fsuma.Show();
            }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                var fresta = new FRESTA();
                fresta.Show();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                var fmultiplicacion = new FMULTIPLICACION();
                fmultiplicacion.Show();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                var fdivision = new FDIVISION();
                fdivision.Show();
            }
        }
    }
}
