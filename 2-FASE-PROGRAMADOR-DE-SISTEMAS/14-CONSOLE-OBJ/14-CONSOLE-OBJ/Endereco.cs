using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_CONSOLE_OBJ
{
    internal class Endereco
    {
        public string rua;
        public string bairro;
        public string cidade; 

        public Endereco(string rua, string bairro, string cidade)
        {
            this.rua = rua;
            this.bairro = bairro;
            this.cidade = cidade;
        }

        public void mostra2()
        {
            Console.WriteLine($"Rua:{rua}\nBAirro:{bairro}\nCidade:{cidade}");
        }
    }
}
