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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Esconde o formulário de login
            ResetarSenhaForm resetarSenhaForm = new ResetarSenhaForm();
            resetarSenhaForm.FormClosed += (s, args) => this.Show(); // Quando fechar o cadastro, mostra o formulário de login
            resetarSenhaForm.Show(); 
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string usuario = usuarioTextBox.Text.Trim();
            string senha = senhaTextBox.Text.Trim();
            var db = new LoginDb();

            if (db.Autenticar(usuario, senha))
            {
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide(); // Esconde o formulário de login
            CadastroForm cadastroForm = new CadastroForm();
            cadastroForm.FormClosed += (s, args) => this.Show(); // Quando fechar o cadastro, mostra o formulário de login
            cadastroForm.Show();
        }
    }
}
