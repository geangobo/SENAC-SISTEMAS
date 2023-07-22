using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aula-06: Exercícios

            //AT1:
            //Declaração de variáveis
            /*
            int num;

            Console.WriteLine("Digite um número de 1 a 10");
            num = int.Parse(Console.ReadLine());

            if (num <= 10)
            {
                Console.WriteLine($"Numero {num} válido!");
                return;
            }else{
                Console.WriteLine($"Número {num} não válido! ");
            }
            */
            //AT2: Login e cadastro de usuários. 
            Console.WriteLine("\n\nBem-vindo ao Conradito's Bank\nOpções:\n1 - Cadastrar\n2 - Login");
            string escolha;
            string user;
            int senha;


             escolha = Console.ReadLine();

            if (escolha == "1")
            {
                Console.WriteLine("Bem-vindo ao cadastro:\nDigite o nome de usuário: ");
                user = Console.ReadLine();
                Console.WriteLine($"Usuário {user} crie uma senha: ");
                senha = int.Parse(Console.ReadLine());
                Console.WriteLine($"Usuário {user} cadastrado com sucesso!\n ");
                




            }
            else
            {
                Console.WriteLine("---Login de usuário\nPara continuar, digite o usuário: ");
                user = Console.ReadLine();
                if (user == "geangobo")
                {
                    Console.WriteLine("Digite a sua senha: ");
                    senha = int.Parse(Console.ReadLine());
                    if (senha == 1234)
                    {
                        Console.WriteLine($"\nBem-vindo {user} ao Conradito's Bank!\nVocê está logado!\n\n");
                        Console.ReadKey();
                    }
                }
            }

            Console.WriteLine("---Login de usuário\nPara continuar, digite o usuário: ");
            user = Console.ReadLine();
            if (escolha == "1")
            {
                if(escolha == "1")
                {
                    Console.WriteLine("Digite a sua senha: ");
                    senha = int.Parse(Console.ReadLine());
                    Console.WriteLine($"\nBem-vindo {user} ao Conradito's Bank!\nVocê está logado!\n\n\n");
                }
                    
            }
            else
            {
                Console.WriteLine("Você errou a sua senha! ");
            }





            //loop no código
            Main(null);
            //Travando terminal
            Console.ReadKey();
        }
    }
}
