/* Exercício 6: Classe Funcionário
Desenvolva uma classe Funcionario com os atributos nome, salario e cargo. 
Instancie um objeto e exiba suas informações. */

Funcionario funcionario1 = new Funcionario();
funcionario1.nome = "Ignácio";
funcionario1.salario = 2500;
funcionario1.cargo = "Desenvolvedor Full STACK";
Console.WriteLine($"{funcionario1.nome}, {funcionario1.salario}, {funcionario1.cargo}.");
public class Funcionario {
    public string? nome;
    public double salario;
    public string? cargo;
}