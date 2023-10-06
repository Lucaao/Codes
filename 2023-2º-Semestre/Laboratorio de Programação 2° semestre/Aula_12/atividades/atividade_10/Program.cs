/* Exercício 10: Classe Filme
Desenvolva uma classe Filme com atributos titulo, diretor e anoLancamento. 
Crie um objeto e mostre suas propriedades no console. */

Filme filme1 = new Filme ();
filme1.titulo = "As 3 Espiãs D+";
filme1.diretor = "Albert Einstein";
filme1.anoLancamento = 2024;
Console.WriteLine($"{filme1.titulo}, {filme1.diretor}, {filme1.anoLancamento}.");
public class Filme {
    public string? titulo;
    public string? diretor;
    public double anoLancamento;
}