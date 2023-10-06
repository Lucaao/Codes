/* Exercício 4: Classe Curso
Crie uma classe Curso com os atributos nome, duracao e professor. 
Crie três objetos desta classe e imprima suas informações no console.*/

Curso curso1 = new Curso();
curso1.nome = "Artes";
curso1.duracao = 02.00;
curso1.professor = "Cabral";

Curso curso2 = new Curso();
curso2.nome = "História";
curso2.duracao = 03.00;
curso2.professor = "Rogério";

Curso curso3 = new Curso();
curso3.nome = "Matemática";
curso3.duracao = 02.30;
curso3.professor = "Renata";

Console.WriteLine($"{curso1.nome}, {curso1.duracao}, {curso1.professor}.\n{curso2.nome}, {curso2.duracao}, {curso2.professor}. \n{curso3.nome}, {curso3.duracao} , {curso3.professor}.");
public class Curso {
    public string? nome;
    public double duracao;
    public string? professor;
}