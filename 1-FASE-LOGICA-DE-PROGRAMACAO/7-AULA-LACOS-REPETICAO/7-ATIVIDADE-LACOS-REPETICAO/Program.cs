using System;

namespace MaquinaDeCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saldo inicial
            double saldo = 0.0;

            //Laço de repetição enquanto for verdadeiro a condição. Estudado por fora. 
            while (true)
            {
                //Mensagens de boas-vindas
                Console.WriteLine("Bem-vindo à máquina de café!");

                //Entrada de dados do valor e mensagens sobre os preços
                Console.WriteLine("\nOpções de café:");
                Console.WriteLine("1. Café expresso - R$ 3,00");
                Console.WriteLine("2. Capuccino - R$ 4,50");
                Console.WriteLine("3. Mocaccino - R$ 6,00");
                Console.WriteLine("4. Água quente - R$ 1,00");

                
                Console.Write("Insira o valor que deseja depositar (caso tenha saldo digite 0): ");
                double valorInserido = Convert.ToDouble(Console.ReadLine());

                //Técnica de contagem, o valor de saldo será somado com valor inserido cada vez que o código for executado no while
                saldo += valorInserido; 

                //Escolha do tipo de bebida
                Console.Write("\nEscolha a opção desejada: ");
                int opcao = Convert.ToInt32(Console.ReadLine());

                string nomeCafe = "";
                double valorCafe = 0.0;

                if (opcao == 1 && saldo >= 3.00)
                {
                    nomeCafe = "Café expresso";
                    valorCafe = 3.00;
                }
                else if (opcao == 2 && saldo >= 4.50)
                {
                    nomeCafe = "Capuccino";
                    valorCafe = 4.50;
                }
                else if (opcao == 3 && saldo >= 6.00)
                {
                    nomeCafe = "Mocaccino";
                    valorCafe = 6.00;
                }
                else if (opcao == 4 && saldo >= 1.00)
                {
                    nomeCafe = "Água quente";
                    valorCafe = 1.00;
                }
                else
                {
                    Console.WriteLine("\nOpção inválida ou saldo insuficiente. Escolha uma opção válida ou deposite mais dinheiro.");
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                saldo -= valorCafe; // Subtrair o valor do café do saldo

                Console.WriteLine($"\nPreparando {nomeCafe}...");
                // Código para preparar o café selecionado
                Console.WriteLine($"{nomeCafe} pronto! Aproveite!");

                //Condicional do saldo em conta.
                if (saldo > 0)
                {
                    Console.WriteLine($"\nSeu saldo atual é de R$ {saldo:F2}"); //Em que F significa float e 2 o número de casas decimais.
                }else{
                    System.Console.WriteLine("Seu saldo foi esgotado, coloque mais dinheiro na máquina!\n\n ");
                    
                }

                Console.WriteLine("Deseja fazer mais uma compra ? \nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
