using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_7_atividadesdolivro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atividades do livro, a partir da pg. 75
            //Primeira do livro
            /*
            double numero;

            Console.WriteLine("Digite um número:");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                Console.WriteLine($"O seu {numero} é maior que 10!");
                Console.WriteLine($"Então o {numero} será multiplicado por 0.1!\n ");
                numero = numero * 0.1; //Colocamos o f para sinalizar que o número é float e não double, também usado para números quebrados.
            }
            else
            {
                Console.WriteLine("Numero digitado é menor que 10! ");
            }
            */

            //Atividade pg. 77 - Atividade 1
            /*
            double numero;

            Console.WriteLine("Digite um número:");
            numero = double.Parse(Console.ReadLine());

            if (numero > 100)
            {
                Console.WriteLine($"O seu {numero} é maior que 100!");
                Console.WriteLine($"Então o {numero} será somado com 150!\n ");
                numero = numero + 150; //Colocamos o f para sinalizar que o número é float e não double, também usado para números quebrados.
            }
            else
            {
                Console.WriteLine("Numero digitado é menor que 100! ");
                Main(null);
            }
            Console.WriteLine($"O número é {numero}");
            */

            //Atividade pg. 81 - Atividade 2
            /*
            double num1;
            double num2;
            double resto1;
            

            Console.WriteLine("Digite o primeiro número: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            resto1 = num1 % num2;
            
            if (resto1 == 0){
                Console.WriteLine($"A divisão {num1} por {num2} é exata!");
            }
            else
            {
                Console.WriteLine($"A divisão {num1} por {num2} NÃO é exata!");
            }
            */

            //Atividade pg.84 - Continuação da Atividade 2
            /*
            double nota1;
            double nota2;
            double media;


            Console.WriteLine("Digite a sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            Console.WriteLine($"A sua média é {media}");

            if (media > 6.0)
            {
                Console.WriteLine($"Média {media} superior à média mínima de 6.0");
            }else if( media == 0)
            {
                Console.WriteLine($"Média {media} igual à média mímina de 6.0");

            }
            else
            {
                Console.WriteLine($"Média {media} inferior à média mímima de 6.0");
            }
            */

            //Atividade pg.88 - Atividade 3
            double nota1;
            double nota2;
            double nota3;
            double media;


            Console.WriteLine("Digite a sua primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua terceira nota: ");
            nota3 = double.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"A sua média é {media}");


            if (nota1 > nota2)
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota1}");
            }
            else if (nota1 > nota3)
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota1}");

            }
            else if(nota2 > nota1)
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota2}");
            }else if (nota2 > nota3)
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota2}");

            }
            else if (nota3 > nota1)
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota3}");

            }
            else
            {
                Console.WriteLine($"A sua média é {media} e a sua maior nota é {nota3}");

            }








            Main(null);
            Console.ReadKey();

        }
            

    }
}
