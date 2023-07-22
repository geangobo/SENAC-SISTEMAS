using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Variáveis
        string escolha;
        string usuario;
        string nome_alterar;
        string nome_alterado;
        int indice = 0;

        // Lista com os nome de usuários
        List<string> nomes = new List<string>();

        // Loop principal
        while (true)
        {
            // Mensagens de boas-vindas e instruções
            Console.WriteLine("\n---Cadastro de usuários:\n1 - Cadastrar\n2 - Buscar\n3 - Deletar\n4 - Alterar\n5 - Listar usuários\nDigite uma opção:");

            escolha = Console.ReadLine();

            if (escolha == "1") //cadastro
            {
                Console.WriteLine("\nDigite o nome que deseja cadastrar: ");
                usuario = Console.ReadLine();
                nomes.Add(usuario);
            }
            else if (escolha == "2") //Busca
            {
                Console.WriteLine("\nDigite a posição que deseja buscar: ");
                indice = int.Parse(Console.ReadLine());

                if (indice >= 0 && indice < nomes.Count)
                {
                    Console.WriteLine("Nome: " + nomes[indice]);
                }
                else
                {
                    Console.WriteLine("Posição inválida!");
                }
            }
            else if(escolha == "3") //Deletar
            {
                System.Console.WriteLine("\nDigite a posição que deseja deletar: ");
                indice = int.Parse(Console.ReadLine());
                if (indice >= 0 && indice < nomes.Count){
                    nomes.RemoveAt(indice); //Removendo o usuário, porém, a lista será re-ordenada.
                    System.Console.WriteLine("Usuário Deletado: " + nomes[indice]);

                }else{
                    System.Console.WriteLine("Posição inválida!");
                }

            }
            else if(escolha == "4")//Alterar
            {
                System.Console.WriteLine("\nDigite um nome já cadastrado para altera-lo: ");
                nome_alterar = Console.ReadLine();
                 bool nome_na_lista = nomes.Contains(nome_alterar);
                if (nome_na_lista){
                    
                    int index = nomes.IndexOf(nome_alterar); //Isso vai retornar o índice do elemento que pesquisei.
                    //Mensagens de alteração
                    System.Console.WriteLine("--Digite um nome cadastrado para alterar: ");
                    System.Console.WriteLine("--O nome a seguir foi alterado com sucesso de: "+nomes[index]);
                    
                    //Entrada de dados do nome que será alterado, para ser colocado no índice
                    nome_alterado = Console.ReadLine();
                    nomes[index] = nome_alterado;
                    System.Console.WriteLine($"--Para o seguinte nome: {nome_alterado}");

                }else{
                    System.Console.WriteLine("Esse nome não existe na lista! ");
                }
            }
            else if(escolha == "5"){
                System.Console.WriteLine("\nListagem de todos dos cadastrados: ");
                string lista_nomes = string.Join(", ", nomes);
                System.Console.WriteLine(lista_nomes);
                Main(null);


            }
            else
            {
                Console.WriteLine("\nEscolha inválida. Re-inicie o programa.");
                break;
            }


        }
    }
}
