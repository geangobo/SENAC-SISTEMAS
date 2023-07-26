using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_CONSOLE_CLASSES_POO
{
    internal class Pessoa
    {
        //Atributos
        public string nome;
        public int idade;
        public string rua;
        public string cidade; 

        //método construtor --Deve ser udado um nome iguazinho ao de sua classe
        public Pessoa(string nome, int idade, string rua, string cidade)
        {
            this.nome = nome; //Esse nome da classe recebe nome.
            this.idade = idade;
            this.rua = rua;
            this.cidade = cidade;
            Console.WriteLine("Foi criado o método construtor");
        }

        //métodos
        public void mostra()
        {
            Console.WriteLine($"Nome:{nome}\nIdade:{idade}\nRua:{rua}\nCidade:{idade}\n");
        }

    }
}
