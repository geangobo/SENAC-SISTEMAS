using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_9_produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>() {"pepsi","fanta" };
            while (true)
            {
                Console.WriteLine("\nBem-vindo ao Conradito Store");
                Console.WriteLine("Digite: \n1 - Cadastrar\n2 - Listar");

                string resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    Console.WriteLine("\nDigite o nome do produto: \n");
                    string produto = Console.ReadLine();
                    string maiuscula;
                    string resto;

                    maiuscula = produto.Substring(0,1);
                    maiuscula.ToUpper();

                    resto = produto.Substring(1,3);

                    produto = maiuscula + resto;


                    if (produtos.Contains(produto))
                    {
                        Console.WriteLine("Esse produto está na lista! ");
                    }
                    else
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado! ");


                    }



                }
                else
                {
                    //Listar as coisas dentro da lista: Poderia usar o string.Join(", ", sua_lista) mas aqui é a construção em sua indexação para, mostrar as coisas de dentro da lista sem usar indexação.
                    //string texto = "";
                    //int contador = 0;
                    //while (contador < produtos.Count)
                    //{
                    //Console.WriteLine($"Produtos: {produtos[contador]}");
                    // texto += produtos[contador] + ", ";//porém, fica uma única virgula, vamos excluir ela. 
                    //contador++;
                    //}
                    
                    string texto_tratado = string.Join(", ", produtos);


                    Console.WriteLine(texto_tratado);
                }


                Console.ReadKey();
            }
            

            
        }
    }
}
