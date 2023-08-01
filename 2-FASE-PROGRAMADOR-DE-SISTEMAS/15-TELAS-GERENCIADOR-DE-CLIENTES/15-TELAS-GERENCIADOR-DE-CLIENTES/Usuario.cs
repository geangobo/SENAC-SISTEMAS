using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    internal class Usuario
    {
        public string usuario;
        public string senha;


        public Usuario(string usuario, string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }
    }
}
