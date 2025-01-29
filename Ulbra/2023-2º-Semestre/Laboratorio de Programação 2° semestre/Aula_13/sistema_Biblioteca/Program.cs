/* Uma biblioteca deseja criar um sistema simples para gerenciar livros e empréstimos. 
O objetivo é criar classes e objetos que permitam representar os livros e os empréstimos feitos. */

Usuario usuario1 = new Usuario();
usuario1.nome = "Bina";
usuario1.endereco = "Rua dos Andrades";
usuario1.telefone = "51 9 7257-4936";

Usuario usuario2 = new Usuario();
usuario2.nome = "John Lennon";
usuario2.endereco = "Rua 21 de maio";
usuario2.telefone = "51 9 9358-2140";


Livro livro1 = new Livro();
livro1.titulo = "A volta dos que não foram";
livro1.autor = "Bob Burnquist";
livro1.anoPublicacao = 2020;
livro1.disponivel = false;

Livro livro2 = new Livro();
livro2.titulo = "A ida dos que voltaram";
livro2.autor = "Burnquist Bob";
livro2.anoPublicacao = 2002;
livro2.disponivel = true;


Emprestimo emprestimo1 = new Emprestimo ();
emprestimo1.usuario = usuario1;
emprestimo1.livro = livro1;
emprestimo1.dataDevolucao = DateTime.Now.AddMonths(3);
emprestimo1.dataEmprestimo = new DateTime(2023, 12, 29);

Emprestimo emprestimo2 = new Emprestimo ();
emprestimo2.usuario = usuario2;
emprestimo2.livro = livro2;
emprestimo2.dataDevolucao = DateTime.Now.AddMonths(3);
emprestimo2.dataEmprestimo = new DateTime(2023, 11, 25);

Console.WriteLine($"\nUsuario: {emprestimo1.usuario.nome} \nLivro: {emprestimo1.livro.titulo} \nData do empréstimo: {emprestimo1.dataEmprestimo} \nData da devolução: {emprestimo1.dataDevolucao} \nDisponibilidade: {emprestimo1.livro.disponivel}.\n");
Console.WriteLine($"Usuario: {emprestimo2.usuario.nome} \nLivro: {emprestimo2.livro.titulo} \nData do empréstimo: {emprestimo2.dataEmprestimo} \nData da devolução: {emprestimo2.dataDevolucao} \nDisponibilidade: {emprestimo2.livro.disponivel}.\n");

public class Livro {
    public string? titulo;
    public string? autor;
    public int anoPublicacao;
    public bool disponivel;
}

public class Usuario {
    public string? nome;
    public string? endereco;
    public string? telefone;
}

public class Emprestimo {
    public Usuario? usuario;
    public Livro? livro;
    public DateTime dataEmprestimo;
    public DateTime dataDevolucao;
}