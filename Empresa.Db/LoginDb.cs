using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Empresa.Models;
using System.Net.Http.Headers;


namespace Empresa.Db
{
    public class LoginDb
    {
        public void Create(Login login)
        {
            // Código para incluir cliente

            string sql = "INSERT INTO Usuarios (Nome,Usuario,Email,Senha) VALUES (@Nome,@Usuario,@Email,@Senha)";
            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Nome", login.Nome);
            cmd.Parameters.AddWithValue("@Usuario", login.Usuario);
            cmd.Parameters.AddWithValue("@Email", login.Email);
            cmd.Parameters.AddWithValue("@Senha",login.Senha);

            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        public bool Autenticar(string usuario, string senha)
        {
            //Código para autenticar usuário
            string sql = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@Usuario AND Senha=@Senha";

            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Senha", senha);
            cn.Open();
            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        public bool ResetarSenha(string usuario, string email, string senha)
        {
            string sql = "UPDATE Usuarios SET Senha=@Senha WHERE Usuario=@Usuario AND Email=@Email";

            var cn = new SqlConnection(Db.Conexao);
            var cmd = new SqlCommand(sql, cn);
            {
                cmd.Parameters.AddWithValue("@Senha", senha);
                cmd.Parameters.AddWithValue("@Usuario", usuario);
                cmd.Parameters.AddWithValue("@Email", email);

                cn.Open();
                int count = cmd.ExecuteNonQuery();
                return count > 0;
            }
        }
    }
}
