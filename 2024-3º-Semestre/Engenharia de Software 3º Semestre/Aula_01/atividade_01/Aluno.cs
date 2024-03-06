// Classe publica Aluno com seus atributos
public class Aluno {
    public string? nome;
    public int idade;
    public int matricula;
    public string? curso;

    // Construtor Aluno, para instanciar com parâmetros
    public Aluno(string nome, int idade, int matricula, string curso){
        this.nome = nome;
        this.idade = idade;
        this.matricula = matricula;
        this.curso = curso;
    }
    
    // Método monstrarInformações para gerar a ação de mostrar todas infos do aluno
    public void mostrarInformacoes(){
        Console.WriteLine($" Informações ALUNO! \n Nome: {nome}.\n Idade: {idade}. \n Matricula: {matricula}. \n Curso: {curso}.\n");
    }
}