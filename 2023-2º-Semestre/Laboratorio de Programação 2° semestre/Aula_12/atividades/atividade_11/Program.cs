/* Exercício 11: Classe Estudante
Desenvolva uma classe chamada Estudante com os atributos nome, curso e idade. 
Inicialize dois objetos desta classe e exiba suas informações. */

Estudante estudante1 = new Estudante ();
estudante1.nome = "Adamastor";
estudante1.curso = "Poesia";
estudante1.idade = 80;

Estudante estudante2 = new Estudante ();
estudante2.nome = "Pedro inácio";
estudante2.curso = "Musica";
estudante2.idade = 25;
Console.WriteLine($"{estudante1.nome}, {estudante1.curso}, {estudante1.idade}. \n{estudante2.nome}, {estudante2.curso}, {estudante2.idade}.");
public class Estudante {
    public string? nome;
    public string? curso;
    public double idade;
}