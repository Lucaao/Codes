/* 1- Declare as variáveis nome, idade e nota atribuindo os valores “Paulo”, 17 e 7.5 e exiba a saída no formato:
Aluno tem anos e nota usando a concatenação e a interpolação de strings. */
/* 2- Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes. */

string nome = "Paulo";
double idade = 17;
float nota = 7.5f;

/* Interpolação */
Console.WriteLine("Atividade 1");
Console.WriteLine($"O aluno {nome} tem {idade} anos e sua nota é {nota}");

/* Concatenação */
Console.WriteLine("O aluno " + nome + " tem " + idade + " anos e sua nota é " + nota);

/* Sequência de escapes */
Console.WriteLine("\nAtividade 2");
Console.WriteLine($"O aluno {nome} \nTem {idade} anos \nE sua nota é {nota}");