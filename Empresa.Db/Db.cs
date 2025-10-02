using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Db
{
    //Helper para acesso a dados
    public static class Db
    {
        public static string Conexao
        {
            get
            {
                return @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Empresa.PIM;Integrated Security=True;Pooling=False";
            }
        }
    }
}
