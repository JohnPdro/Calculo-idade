using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int diasAno;
            int mes;
            int idade;
            if (Convert.ToInt32(txtAno.Text) <= 2023)
            {
                idade = 2023 - Convert.ToInt32(txtAno.Text);
                diasAno = idade * 365;
                if (Convert.ToInt32(txtMes.Text) < 13)
                {
                    mes = Convert.ToInt32(txtMes.Text) * 30;
                    int resultado =(mes + diasAno) - Convert.ToInt32(txtDia.Text);
                    lblResultado.Text = Convert.ToString(resultado);
                }
            } 
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
