using HashsCSharp.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashsCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //Criar uma instância do algoritmo definido.
            SHA256 algoritmo = SHA256.Create();

            string valor = txtValor.Text;

            Hashs cripotgrafia = new Hashs(algoritmo);

            string retorno = cripotgrafia.getHash(valor);

            lblResultado.Text = retorno;
        }
    }
}
