using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Models
{
    public sealed class Login
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
