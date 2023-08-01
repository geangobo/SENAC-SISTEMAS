using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CONSOLE_OBJ
{
    internal class Pessoa
    {
        //atributos
        private string nome;
        private int idade;
        public bool inadimplente = false;
        public Endereco endereco;

        //Construtor
        public Pessoa(string nome, int idade, string rua, string bairro, string cidade)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = new Endereco(rua, bairro, cidade);
            

        }

        //métodos
        public void mostra()
        {
            Console.WriteLine($"Eu sou o {nome} e tenho {idade} meu endereço é: ");
        }
    }
}
