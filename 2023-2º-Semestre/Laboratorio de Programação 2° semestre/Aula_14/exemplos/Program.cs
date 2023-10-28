/* Exemplos */

Pessoa pessoa = new Pessoa ();
pessoa.Saudacao("Lucas", "18/10/2013");

Calculadora calculadora = new Calculadora();
int resultado = calculadora.Somar(10,5);
Console.WriteLine($"O resultado é {resultado}.");

int resultado2 = calculadora.Somar(10,5,5);
Console.WriteLine($"O resultado é {resultado2}.");

Console.WriteLine(calculadora.Somar(13.2, 13.4));
Console.WriteLine(calculadora.Subtrair(25, 10));
Console.WriteLine(calculadora.Multiplicar(5, 10));

Mensagem mensagem = new Mensagem ();
mensagem.Exibir();

Quadrado quadrado = new Quadrado ();
quadrado.Numero = 10;

quadrado.CalcularQuadrado();




// Biblioteca e livro //


Livro livro1 = new Livro ();
livro1.titulo = "Código Limpo";
livro1.autor = "Paulo Lopez";
livro1.status = true;

Livro livro2 = new Livro ();
livro2.titulo = "Código Sujo";
livro2.autor = "Bernardo Campos";
livro2.status = true;

Livro livro3 = new Livro ();
livro3.titulo = "Código Desconhecido";
livro3.autor = "Bina";
livro3.status = false;

Biblioteca biblioteca = new Biblioteca ();
biblioteca.adicionarLivros(livro1);
biblioteca.adicionarLivros(livro2);
biblioteca.adicionarLivros(livro3);

int livrosDisponiveis = biblioteca.qtdLivrosDisponiveis();
Console.WriteLine("Livros disponiveis: " + livrosDisponiveis);

Livro livroEncontrado = new Livro();
livroEncontrado = biblioteca.buscarPeloTitulo("");
if (){
    
}