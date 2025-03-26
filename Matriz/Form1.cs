using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class frmMatriz : Form
    {
        double[,] matriz = new double[3, 3];
        int i = 0; // numero de linhas
        int j = 0; // numero de colunas


        public frmMatriz()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = Double.Parse(txtMatriz.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtMatriz.Text = "";
            }
        }

        private void btnMostrarMatriz_Click(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    txtMatriz.Text += matriz[i, j].ToString() + " ";
                }
                txtMatriz.Text += Environment.NewLine;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = Double.Parse(txtMatriz.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtMatriz.Text = "";
            }
        }

        private void txtMatriz_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMatriz_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                matriz[i, j] = Double.Parse(txtMatriz.Text);
                j++;
                if (j == 3)
                {
                    i++;
                    j = 0;
                }
                txtMatriz.Text = "";
            }

        }

        private void btnMostrarMatriz_Click_1(object sender, EventArgs e)
        {
            for (i = 0; i <= 2; i++)
            {
                for (j = 0; j <= 2; j++)
                {
                    textBox1.Text += matriz[i, j].ToString() + " ";
                }
                textBox1.Text += Environment.NewLine;
            }


        }

        private void btnExibirMaior_Click(object sender, EventArgs e)
        {
            {
                double maiorValor = double.MinValue;

                // Percorre a matriz para encontrar o maior valor
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        if (matriz[i, j] > maiorValor)
                        {
                            maiorValor = matriz[i, j];
                        }
                    }
                }

                // Exibe o maior valor encontrado
                MessageBox.Show($"O maior valor encontrado na matriz é: {maiorValor}");
            }
        }
    }
}


        


   
