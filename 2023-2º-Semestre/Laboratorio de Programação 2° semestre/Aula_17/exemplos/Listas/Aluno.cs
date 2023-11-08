using System.Security.Cryptography.X509Certificates;

class Aluno {
    public string? nome;
    private int nota;
    public int getNota(){
        Random random = new Random();
        return random.Next(1,10);
    }
    public void setNota(int nota){
        this.nota = nota;
    }
    public Aluno(string nome){
        this.nome = nome;
        this.nota = 1;
    }
}
// Construtores e operador THIS //
// Modificadores de acesso, PUBLIC, PRIVATE ou nada também é PRIVATE //