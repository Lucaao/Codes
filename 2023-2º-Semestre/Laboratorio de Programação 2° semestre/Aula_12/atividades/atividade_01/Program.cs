/* Exercício 1: Classe Pessoa
Crie uma classe Pessoa com os atributos nome, idade e cidadeNatal. 
Inicialize um objeto desta classe e exiba seus atributos no console. */

    Pessoa P1 = new Pessoa();
    P1.nome = "Lucas";
    P1.idade = 21;
    P1.cidadeNatal = "Torres";
    Console.WriteLine($"{P1.nome}, {P1.idade}, {P1.cidadeNatal}.");
class Pessoa {
    public string? nome;
    public double idade;
    public string? cidadeNatal;
}