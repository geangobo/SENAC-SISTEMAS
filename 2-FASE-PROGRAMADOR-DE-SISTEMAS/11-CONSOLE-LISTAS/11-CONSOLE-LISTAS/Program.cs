//Início dos estudos em POO (Programação Orientado a Objetos) em C#
/*
List<string> imagens = new List<string>();
List<string> nomes = new List<string>();

nomes.Add("Mago");
nomes.Add("Guerreiro");

imagens.Add("imagens/mago.png");
imagens.Add("imagens/guerreiro.png");
*/

//Criado a classe, podemos usar ela como se fosse uma variável: 
using _11_CONSOLE_LISTAS;

Personagem a = new Personagem();
/*
//Criando uma instância da classe no caso guerreiro: 
Personagem guerreiro = new Personagem(); //Assim vou criar uma novo classe de personagem. 
guerreiro.nome = "O grande Conrado";
guerreiro.raca = "Humano";
guerreiro.poder = 100;


//Console.WriteLine($"O seu personagem é {guerreiro.raca}, seu nome é {guerreiro.nome} e o poder {guerreiro.poder}!");

//Criando a instância personagem mago
Personagem mago = new Personagem();
mago.nome = "Gean";
mago.raca = "Elfo";
mago.poder = 150;

//Console.WriteLine($"Nome: {mago.nome} \nRaça: {mago.raca}\nPoder: {mago.poder}");

//mago.mostraPersonagem(); //Desse modo, chamamos a função de mostrar personagem. Onde ela foi desenvolvida dentro da classe. 


//Criando hulk
Personagem hulk = new Personagem();
hulk.nome = "Hulk";
hulk.raca = "Pitbull";
hulk.poder = 1000;

hulk.mostraPersonagem();
*/

//Criando os produtos: 

Produtos Rexona = new Produtos();
Rexona.nome = "Rexona";
Rexona.descricao = "Spray anti-transpirante com perfume.";
Rexona.quantidade = 10;
Rexona.preco = 12.50;
Rexona.status = true;

//produtos.desativaProduto();
Rexona.mostrarProduto();

Produtos arroz = new Produtos();
arroz.nome = "Namorado";
arroz.descricao = "Arroz integral tipo A";
arroz.quantidade = 20;
arroz.preco = 20.50;
arroz.status = true;

//arroz.desativaProduto();
arroz.mostrarProduto();


Produtos feijao = new Produtos();
feijao.nome= "Feijoada preta";
feijao.descricao = "Feijão importado preto";
feijao.quantidade = 30;
feijao.preco = 15.50;
feijao.status = true;

feijao.desativaProduto();
feijao.mostrarProduto();






