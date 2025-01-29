/* Exercício 3: Classe Animal
Implemente uma classe Animal com os atributos especie, nome e idade. 
Inicialize dois objetos desta classe com diferentes atributos e exiba-os no console. */

Animal animal1 = new Animal();
animal1.especie = "Tigre";
animal1.nome = "Antenor";
animal1.idade = 10;

Animal animal2 = new Animal();
animal2.especie = "Coruja";
animal2.nome = "Eustácio";
animal2.idade = 25;

Console.WriteLine($"{animal1.especie}, {animal1.nome}, {animal1.idade}. \n{animal2.especie}, {animal2.nome}, {animal2.idade}.");
public class Animal {
    public string? especie;
    public string? nome;
    public double idade;
}