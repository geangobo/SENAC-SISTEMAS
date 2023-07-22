using System; 

namespace Aula6Atividade
{
    class Aula6Atividade
    {
        static void Main(string[] args)
        {
            //Você deve desenvolver um programa de vendas de passagens aéreas.
            //Etapa-1: 

            //Vairáveis:
            string agosto = "08"; 
            string setembro = "09";
            string outubro = "10";
            string escolha1;
            string escolha2;
            string user;
            string dia = "";
            string mes = "";
            string periodo = "";

            //Mensagem de apresentação:
            System.Console.WriteLine("╔═══════════════════•ೋೋ•═══════════════════╗\n  Bem-vindo(a) TripCode Viagens e Turismo!\n╚═══════════════════•ೋೋ•═══════════════════╝");
            System.Console.WriteLine("Digite o seu nome: ");
            user = Console.ReadLine();
            System.Console.WriteLine($"Olá {user}, Datas de viagens disponíveis:\n08 - Agosto   (Digite 1)\n09 - Setembro (Digite 2)\n10 - Outubro  (Digite 3)");

            //Bloco de condicionais: Vou receber uma variável escolha e ela vai ser julgada verdadeira ou falsa pelos condicionais.
            escolha1 = Console.ReadLine();

            if (escolha1 == "1"){
                System.Console.WriteLine($"{user} viajará dia 08 de agosto!\n");
            }else if(escolha1 == "2"){
                System.Console.WriteLine($"{user} viajará dia 09 de Setembro!\n");
            }else if(escolha1 == "3"){
                System.Console.WriteLine($"{user} viajará dia 10 de Outubro\n");
            }else{
                System.Console.WriteLine("Mês inválido, clique (enter) para reiniciar o programa!");
                Console.ReadKey();
                Main(null);
            }    
            
            //Período da viagem:
            System.Console.WriteLine($"Em qual período você deseja viajar {user} ?");
            System.Console.WriteLine("--Manhã (Digite 1)\n--Tarde(Digite 2)\n--Noite (Digite 3)");
            
            //Bloco de condiconais 2: Período de viagem
            escolha2 = Console.ReadLine();

            if (escolha2 == "1"){
                System.Console.WriteLine($"{user} escolheu o período da manhã para viajar\n");
                periodo = "Manhã";

            }else if(escolha2 == "2"){
                System.Console.WriteLine($"{user} escolheu o período da tarde para viajar\n");
                periodo = "Tarde";

            }else if (escolha2 == "3"){
                System.Console.WriteLine($"{user} escolheu o período da tarde para viajar\n");
                periodo = "Noite";

            }else{
                System.Console.WriteLine($"{user} digitou o período errado, por favor, clique enter para reiniciar o sistema");
                Console.ReadKey();
                Main(null);
            }

            //Recibo:

             if (escolha2 == "1"){
                dia = "08";
                mes =  "agosto";
            }else if(escolha2 == "2"){
                dia = "09";
                mes = "Setembro";
            }else if (escolha2 == "3"){
                dia = "10";
                mes = "Outubro";
            }else{
                System.Console.WriteLine($"{user} digitou o período errado, por favor, clique enter para reiniciar o sistema");
                Console.ReadKey();
                Main(null);
            }


            //Dia, mês e período da compra.

            System.Console.WriteLine($"Parabéns usuário {user}, passagem comprada com sucesso para o dia\n {dia} de {mes}, no período {periodo}. Boa viagem!");

            //Etapa 1 - completa!
            //Etapa 2 - acabei fazendo na etapa 1 sem querer para deixar o código melhor, logo, completa!
    


            




            






        }
    }
}
