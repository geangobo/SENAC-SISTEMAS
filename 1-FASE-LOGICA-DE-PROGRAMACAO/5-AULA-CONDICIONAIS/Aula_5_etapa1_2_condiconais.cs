
////###########Etapa 1:
//Mensagem de apresentação
System.Console.WriteLine("Seja bem-vindo(a) a TripCode, empresa de viagens e turismo tecnológico\n\n");

//Variáveis
string nome_cliente1; 
string nome_cliente2;
string bairro; 
string endereco; 
string cidade; 
string estado; 
float viagem_ano1;
float viagem_ano2;
float viagem_total;



//Cadastro do cliente - nome e sobrenome
System.Console.WriteLine("Digite o seu primeiro nome: ");
nome_cliente1 = Console.ReadLine();

System.Console.WriteLine("\nDigite o seu sobrenome: ");
nome_cliente2 = Console.ReadLine();

System.Console.WriteLine($"\n\nOlá Sr(a). {nome_cliente1} {nome_cliente2} vamos continuar o seu cadastro..."); 

//Informções do usuário
System.Console.WriteLine("\nDigite o nome do seu Endereço: ");
endereco = Console.ReadLine();

System.Console.WriteLine("\nDigite o nome do seu Bairro: ");
bairro = Console.ReadLine();

System.Console.WriteLine("\nDigite o nome da sua Cidade: ");
cidade = Console.ReadLine();

System.Console.WriteLine("\nDigite o nome do seu Estado: ");
estado = Console.ReadLine();

//Mensagens de informação do cliente: 
System.Console.WriteLine($"\n--O Sr(a). {nome_cliente2} mora na cidade de {cidade}, Estado de {estado}, no endereço {endereco}, localizado no bairro {bairro}");


//Dados de viagens: 
System.Console.WriteLine($"\n--Quantas viagens você {nome_cliente1} fez ano passado ? ");
viagem_ano1 = float.Parse(Console.ReadLine());

System.Console.WriteLine($"Quantas viagens você {nome_cliente1} planejou fazer nesse ano ? ");
viagem_ano2 = float.Parse(Console.ReadLine());

//Operações matemáticas
viagem_total = viagem_ano1 + viagem_ano2;
System.Console.WriteLine($"\nOlá, cliente {nome_cliente1}, seu total de viagens feitas com a TripCode é {viagem_total}");

//Viagens faltantes
System.Console.WriteLine($"\nFalta apenas {10 - viagem_total} para completar 10 viagens ao todo! ");

//Média de viagens
System.Console.WriteLine($"\nSua média de viagens em relação ao ano passado é {(viagem_ano1 + viagem_ano2)/2}");

//intervalo em meses da cada viagem
System.Console.WriteLine($"\nCom intervalo de {12/viagem_ano2} meses a cada viagem nesse ano");

//Agradecimentos
System.Console.WriteLine($"\n---Obrigado {nome_cliente1} {nome_cliente2}, o seu cadastro foi realizado com sucesso! ");

//Etapa 1 - Concluído.

//###########Etapa 2: Essa etapa envolve o uso de condições para tornar o seu código mais completo.
System.Console.WriteLine("\nDigite o seu cupom de desconto: ");
string cupom;
cupom = Console.ReadLine();

//Condicionais do cumpom
if (cupom == "Conradito10"){
    System.Console.WriteLine("\nParabens, voce recebeu 10% de desconto na sua proxima viagem!\n ");
}else{
    System.Console.WriteLine("Esse cupom não existe! ");
}

//e-mail
System.Console.WriteLine("Você gostaria de promoções no seu E-mail ? ");
string email; 
email = Console.ReadLine();

//Condicional e-mail
if (email == "Sim"){
    System.Console.WriteLine($"\nObrigado {nome_cliente1} por se registrar, você receberá novos e-mails em breve.");
}else{
    System.Console.WriteLine("\nOk! Você não receberá e-mails de promoções.");
}

System.Console.WriteLine("\n--Obrigado, e volte sempre! ");


