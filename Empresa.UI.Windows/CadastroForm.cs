using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Empresa.Models;
using Empresa.Db;

namespace Empresa.UI.Windows
{
    public partial class CadastroForm : Form
    {
        public CadastroForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string senha = senhaTextBox.Text;
            string confirmarSenha = confirmarSenhaTextBox.Text;

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            var login = new Login();
            login.Nome = nomeTextBox.Text;
            login.Email = emailTextBox.Text;
            login.Usuario = usuarioTextBox.Text;
            login.Senha = senhaTextBox.Text;

            if (tipoUsuarioComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione o tipo de usuário!");
                return;
            }
            login.TipoUsuario = tipoUsuarioComboBox.SelectedIndex;

            var db = new Db.LoginDb();
            db.Create(login);

            MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void tipoUsuarioComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
