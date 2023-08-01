using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_PROJETO_BANCOeCLIENTE
{
    internal class Cliente
    {
        //Atributos
        private string nome;
        private string email;
        private string senha;
        public ContaBancaria contabancaria;

        public Cliente(string nome, string email, string senha, double saldo, bool credito, bool debito)
        {
            this.nome = nome;
            this.email = email;
            this.contabancaria = new ContaBancaria(saldo, credito, debito);

        }
        public void mostra()
        {
            Console.WriteLine($"\nNome:{nome}");
        }
    }
}
