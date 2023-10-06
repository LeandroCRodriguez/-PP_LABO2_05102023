

namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        

        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Desea cerrar la calculadora?", "cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void BtnCerrar(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLimpiar(object sender, EventArgs e)
        {
            
        }

        private void BtnOperar(object sender, EventArgs e)
        {
            
            setResultado();

        }
        private void setResultado()
        {
            if (resultado is not null)
            {
                
            }

        }


        private void rdbBinario_checkedChanged(object sender, EventArgs e)
        {
           
        }

        private void rdbDecimal_checkedChanged(object sender, EventArgs e)
        {
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<char> chars = new List<char> { '+', '-', '*', '/' };

            foreach (char c in chars)
            {
                cmbOperacion.Items.Add(c);
            }
            rdbDecimal.Checked = true;
        }



        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}