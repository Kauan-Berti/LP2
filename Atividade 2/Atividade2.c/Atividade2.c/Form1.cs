using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade2.c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar o dado 
            txtnumero1.Clear();
            txtnumero2.Clear();
            txtresultado.Clear();

            txtnumero1.Focus();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
            Double Numero1, Numero2, Resultado;

            if (Double.TryParse(txtnumero1.Text, out Numero1) &&
                Double.TryParse(txtnumero2.Text, out Numero2))
            {
                //Resultado = Numero1 + Numero2;
                Resultado = Numero1 + Numero2;
                txtresultado.Text = Resultado.ToString("");
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            Double Numero1, Numero2, Resultado;

            if (Double.TryParse(txtnumero1.Text, out Numero1) &&
                Double.TryParse(txtnumero2.Text, out Numero2))
            {
                //Resultado = Numero1 - Numero2;
                Resultado = Numero1 - Numero2;
                txtresultado.Text = Resultado.ToString("");
            }
        }

        private void btnmult_Click(object sender, EventArgs e)
        {
            Double Numero1, Numero2, Resultado;

            if (Double.TryParse(txtnumero1.Text, out Numero1) &&
                Double.TryParse(txtnumero2.Text, out Numero2))
            {
                //Resultado = Numero1 * Numero2;
                Resultado = Numero1 * Numero2;
                txtresultado.Text = Resultado.ToString("");
            }
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            Double Numero1, Numero2, Resultado;

            if (Double.TryParse(txtnumero1.Text, out Numero1) &&
                Double.TryParse(txtnumero2.Text, out Numero2))
            {
                if  (Numero2 == 0)
                {
                    MessageBox.Show("Numero1 e Numero2 devem ser diferente que zero");
                }
                else
                {
                    //Resultado = Numero1 / Numero2;
                    Resultado = Numero1 / Numero2;
                    txtresultado.Text = Resultado.ToString("");
                }
            }
        }
    }
}
