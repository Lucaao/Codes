/* 
    Exemplos como instanciar
    var P1 = new Pessoa();
    Pessoa P1 = new ();     */
/*
    Pessoa P1 = new Pessoa();
    P1.nome = "Lucas";
    P1.idade = 21;
    P1.cidadeNatal = "Torres";
    Console.WriteLine($"{P1.nome} {P1.idade} {P1.cidadeNatal}");
    
    Pessoa P2 = new Pessoa();
    P2.nome = "Kiwi";
    P2.idade = 23;
    P2.cidadeNatal = "Florianopolis";
    Console.WriteLine($"{P2.nome} {P2.idade} {P2.cidadeNatal}");
public class Pessoa
{
    public string? nome;
    public double idade;
    public string? cidadeNatal;
} */

/* Exemplo 

Produto P1 = new Produto();
P1.nome = "Retro escavadeira";
P1.preco = 90.00;
P1.categoria = "Máquinas Agricolas";

Produto P2 = new Produto();
P2.nome = "Pão de Batata";
P2.preco = 10.00;
P2.categoria = "Padaria";

Produto P3 = new Produto();
P3.nome = "Escumadeira";
P3.preco = 25.00;
P3.categoria = "Utensilios";

Mercado mercado = new Mercado();
mercado.nome = "Paulo";
mercado.endereco = "Avenida 1 2 3 4";
mercado.produto1 = P1;
mercado.produto2 = P2;
mercado.produto3 = P3;
Console.WriteLine($"{mercado.nome},{mercado.endereco},{mercado.produto1.nome},{mercado.produto2.nome},{mercado.produto3.nome}");

class Produto {
    public string? nome;
    public double preco;
    public string? categoria;
}

class Mercado {
    public string? nome;
    public string? endereco;
    public Produto produto1;
    public Produto produto2;
    public Produto produto3;
} 
*/
Estudante E1 = new Estudante();
    E1.nome = "Lucas";
    E1.idade = 21;

Estudante E2 = new Estudante();
    E2.nome = "Jonas";
    E2.idade = 25;

Estudante E3 = new Estudante();
    E3.nome = "Julia";
    E3.idade = 20;

Turma T1 = new Turma();
T1.numero = 325;
T1.estudante1 = E1;
T1.estudante2 = E2;
T1.estudante3 = E3;

Console.WriteLine($"{T1.numero},{T1.estudante1.nome},{T1.estudante2.nome},{T1.estudante3.nome}.");
class Estudante {
    public string? nome;
    public double idade;
}

class Turma {
    public double numero;
    public Estudante estudante1;
    public Estudante estudante2;
    public Estudante estudante3;
}