/* Exercício 2: Classe Produto
Desenvolva uma classe chamada Produto que contenha os atributos nome, preco e categoria. 
Crie um objeto desta classe e imprima seus atributos na tela. */

Produto comida1 = new Produto();
comida1.nome = "Arroz";
comida1.preco = 25.00;
comida1.categoria = "Alimentos";
Console.WriteLine($"{comida1.nome}, {comida1.preco}, {comida1.categoria}.");
public class Produto {
    public string? nome;
    public double preco;
    public string? categoria;
}