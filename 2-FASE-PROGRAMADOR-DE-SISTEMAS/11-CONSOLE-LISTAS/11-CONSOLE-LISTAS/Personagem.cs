using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CONSOLE_LISTAS
{
    internal class Personagem
    {
        //Uma classe tem variáves (atributos) e...
        public string nome = "";
        public string profissao = "";
        public string raca ="";
        public int poder; 

        //Funções (métodos):
        public void mostraPersonagem()
        {
            Console.WriteLine($"Seu personagem se chama {nome}\nSua raça: {raca}\nSeu poder: {poder}");

        }


    }
}
