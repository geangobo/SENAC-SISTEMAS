using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> estacionamento = new List<string>();


        while (true)
        {
            //Mensagens iniciais de boas vindas e opções a serem escolhidas: 
            System.Console.WriteLine("\n---Bem-vindo(a) ao estacionamento Cidade Aracy---\nDigite o seu nome: ");
            string user = Console.ReadLine();
            System.Console.WriteLine($"\n{user}, escolha uma opção:\n1 - Estacionar\n2 - Retirar veículo\n3 - Listar veículos");


            string opcao = Console.ReadLine();

            if (opcao == "1") //cadastramento de placas 
            {
                Console.Write("Digite a placa do veículo: ");
                string placa = Console.ReadLine().ToUpper();

                if (placa.Length != 6)
                {
                    Console.WriteLine("Placa inválida. A placa deve ter exatamente 6 caracteres.");
                    continue;
                }

                if (estacionamento.Contains(placa))
                {
                    Console.WriteLine("Veículo já estacionado.");
                }
                else
                {
                    estacionamento.Add(placa);
                    Console.WriteLine("Veículo estacionado com sucesso.");
                }
            }
            else if (opcao == "2") //Retirar veículo, logo, usar .Remove
            {
                Console.Write("Digite a placa do veículo a ser retirado: ");
                string placa = Console.ReadLine().ToUpper();

                if (estacionamento.Contains(placa))
                {
                    estacionamento.Remove(placa);
                    Console.WriteLine("Veículo retirado com sucesso.");
                }
                else
                {
                    Console.WriteLine("Veículo não encontrado no estacionamento.");
                }
            }
            else if (opcao == "3") //Listagem das placas
            {
                Console.WriteLine("Vagas ocupadas:");
                for (int i = 0; i < 5; i++) // para i um número inteiro igual a 0, onde i é menor que 5, será contado uma vez i. Pois tenho 5 vagas. 
                {
                    if (i < estacionamento.Count)
                    {
                        Console.Write($"[ {estacionamento[i]} ] ");
                    }
                    else
                    {
                        Console.Write("[ ____ ] ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Opção inválida. Digite novamente.");
            }

            Console.Write("Deseja continuar? (S/N): ");
            string continuar = Console.ReadLine();
            if (continuar.ToUpper() != "S")
                break;
        }

        
        Console.WriteLine("\nObrigado por utilizar o estacionamento Cidade Aracy!");
    }
}
