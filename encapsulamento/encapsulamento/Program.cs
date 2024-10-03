// See https://aka.ms/new-console-template for more information

using encapsulamento;

Pessoa p = new Pessoa();


p.Nome = "Fernanda";
p.Idade = 27;
p.Idade = -0;
p.Telefone = "81 986741517";
p.Email = "aluno.senai@gmail.com";
p.Endereco = "Antiga PE 28, s/n - Jardim Santo Inacio, PE, 54500-000";


Console.WriteLine($"O nome dessa pessoa é: {p.Nome}");
Console.WriteLine($"Essa pessoa tem {p.Idade} anos");
Console.WriteLine($"O Telefone dessa pessoa é {p.Telefone}");
Console.WriteLine($"O email dessa pessoa é {p.Email}");
Console.WriteLine($"O endereço dessa pessoa é {p.Endereco}");

Console.ReadKey();