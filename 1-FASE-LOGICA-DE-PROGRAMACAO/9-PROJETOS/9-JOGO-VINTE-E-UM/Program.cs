using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_9_jogo21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao jogo do 21");
            Console.WriteLine("Seu objetivo é chegar próximo de 21 pontos\n\n");

            //vairáveis e sorteador 
            int pontos = 0;
            Random sorteador = new Random();


            while (pontos <= 21)
            {

                Console.WriteLine($"Você tem {pontos} pontos ");
                Console.WriteLine("Deseja continuar, digite:\n1 - Continua\n2 - Parar");
                string escolha;
                escolha = Console.ReadLine();

                if (escolha == "2")
                {
                    Console.WriteLine($"\nVocê desistiu do jogo com a quantidade de pontos: {pontos} ");
                    Main(null);
                    break; //Para quebrar o loop

                }

                //Criando o intervalo do sorteador
                int numero = sorteador.Next(1, 11);
                pontos += numero;
                Console.WriteLine($"\nVocê tirou o número {numero} ");

                if (pontos > 21)
                {
                    Console.WriteLine("\nVocê perdeu o jogo! Ultrapassou o número de 21 pontos. ");
                }else if (pontos == 21)
                {
                    Console.WriteLine("Você venceu o jogo!");
                    break;
                }
                else
                {
                    Console.WriteLine("Continue jogando! Se você quiser! (Clique Enter) ");
                }


                Console.ReadKey();
            }


        }
    }
}
