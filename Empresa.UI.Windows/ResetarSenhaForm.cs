using Empresa.Db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empresa.UI.Windows
{
    public partial class ResetarSenhaForm : Form
    {
        public ResetarSenhaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }

        private void finalizarButton_Click(object sender, EventArgs e)
        {
            string usuario = usuarioResetTextBox.Text;
            string email = emailResetTextBox.Text; 
            string novaSenha = novaSenhaTextBox.Text;

            var db = new LoginDb();
            bool sucesso = db.ResetarSenha(usuario, email, novaSenha);


            if (sucesso) 
            { 
                MessageBox.Show("Senha alterada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Usuário ou e-mail não encontrados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
