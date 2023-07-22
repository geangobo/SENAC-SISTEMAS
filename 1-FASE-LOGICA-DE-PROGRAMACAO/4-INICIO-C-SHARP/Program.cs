using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula4leitura
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//Variáveis:
            int idade;

            Mensagens:
            Console.WriteLine("Bem-vindo ao Detran!\n");
            Console.WriteLine("Digite a sua idade: ");

            //Entrada de dados:
            idade = int.Parse(Console.ReadLine());

            //Condiconal
            if (idade >= 18){
                Console.WriteLine($"Essa pessoas pode dirigir! Pois você tem {idade} anos");
            }else{
                Console.WriteLine("Essa pessoa NÃO pode dirigir! Pois voc ");
            }
            */

            int idade;
            string sim;
            string nao;
            string dicotomica;
            Console.WriteLine("BEm-vindo ao DETRAN!\nDigite a sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você tem {idade} anos!\n");

            Console.WriteLine("Você já possuí carteira de motorista ? ");
            dicotomica = Console.ReadLine();

            if (dicotomica == "sim")
            {
                Console.WriteLine("Você deve renovar a sua CNH!");
            }else{
                Console.WriteLine("Você deve fazer  sua CNH!");
            }











            Main(null); //Para criar um loop.
            
           

            Console.ReadKey();
        }
        void Revisao()
        {
            float lanche = 8.00f;
            float salcicha = 1.50f;
            float hamburger = 2.00f;
            float requeijao = 1.50f;
            float bacon = 2.00f;

            //operações
            float preco_xtudo = lanche + hamburger + bacon + salcicha;
            float preco_cachorro = lanche + salcicha * 2 + requeijao;
            float preco_moda = lanche + salcicha + hamburger + requeijao + bacon;
            float preco_combo = preco_xtudo + preco_moda + preco_cachorro;


            Console.WriteLine("Cardápio do Conradito Laches \n Valores:");
            Console.WriteLine($"X-Tudo: Pão, 2 salcichas e requeijão -R$ {preco_xtudo}");
            Console.WriteLine($"Cachorro-Quente: Pão hamburguer, bacon, salcicha -R$ {preco_cachorro}");
            Console.WriteLine($"Moda da Casa: Pão, salcicha, hamburguer, requeijão e bacon -R$ {preco_moda}");

            Console.WriteLine($"\n\n COMBO: X-Tudo + Cachorro-quente + Moda da Casa - R$ {preco_combo} ");
            Console.ReadKey();
        }
    }
}
