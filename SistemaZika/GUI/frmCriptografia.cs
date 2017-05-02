using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmCriptografia : Form
    {
        public frmCriptografia()
        {
            InitializeComponent();
        }

        private void frmCriptografar_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string resultado = lblresult.Text;
            
            string normal =  "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            string cifrado = "DEFGHIJKLMNOPQRSTUVWXYZABCdefghijklmnopqrstuvwxyzabc";

            foreach (char letra in texto )
            {
                int indice = normal.IndexOf(letra);
                //operador ternario é u IF na mesma linha
                resultado += indice != -1 ? cifrado[indice]:letra;
            }

            lblresult.Text = resultado;
        }
    }
}
