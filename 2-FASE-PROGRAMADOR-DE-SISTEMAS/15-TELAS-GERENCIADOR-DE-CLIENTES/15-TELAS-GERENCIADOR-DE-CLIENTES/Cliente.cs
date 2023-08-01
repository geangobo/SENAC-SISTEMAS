using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_TELAS_GERENCIADOR_DE_CLIENTES
{
    internal class Cliente
    {
        public string nome;
        public int idade;
        public Usuario usuario;

        public Cliente(string nome, int idade, Usuario usuario)
        {
            this.nome = nome;
            this.idade = idade;
            this.usuario = usuario;
        }
    }
}
