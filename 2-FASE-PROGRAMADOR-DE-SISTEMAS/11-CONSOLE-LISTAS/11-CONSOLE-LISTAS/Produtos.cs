using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_CONSOLE_LISTAS
{
    internal class Produtos
    {
        public string nome = "";
        public string descricao = "";
        public int quantidade;
        public double preco;
        public bool status; 

        //Mostrar produto no console: 
        public void mostrarProduto()
        {
            Console.WriteLine($"\n\nProduto: {nome}\nDescrição: {descricao}\nQuantidade: {quantidade}\nPreço: {preco}\nStatus: {status}");
        }
        public void desativaProduto()
        {
            Console.WriteLine("\n\nProduto Desativado!!!");
            quantidade = 0;
            status = false;

        }
    }
}
