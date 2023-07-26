using _13_CONSOLE_CLASSES_POO;
using System.ComponentModel.DataAnnotations;

Pessoa cliente = new Pessoa("Leonardo", 18, "Rua Detino Pereira dos Santos", "São Carlos");
Pessoa cliente2 = new Pessoa("John", 20, "Rua do Aracy", "São Carlos");

//Para colocar apenas dentro da lista objetos pessoas.
List<Pessoa> pessoas = new List<Pessoa>();
pessoas.Add(cliente);
pessoas.Add(cliente2);

for (int i = 0; i < pessoas.Count; i++)
{
    pessoas[i].mostra(); 
}


