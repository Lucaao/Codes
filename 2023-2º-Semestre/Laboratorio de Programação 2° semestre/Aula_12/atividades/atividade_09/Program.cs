/* Exercício 9: Classe Smartphone
Implemente uma classe Smartphone com atributos marca, modelo e anoLancamento. 
Inicialize um objeto dessa classe e imprima suas informações. */

Smartphone smart1 = new Smartphone();
smart1.marca = "Samsung";
smart1.modelo = "S23 Ultra";
smart1.anoLancamento = 2023;
Console.WriteLine($"{smart1.marca}, {smart1.modelo}, {smart1.anoLancamento}.");
public class Smartphone {
    public string? marca;
    public string? modelo;
    public double anoLancamento;
}