class Turma {
    public string? nome;
    public Aluno[] meusAlunos = new Aluno[2];
    public int TotalNotas(){
        int notas = 0;
        for(int i = 0; i <= meusAlunos.Length; i++){
            notas = notas + meusAlunos[i].getNota();
            //
        }
        return notas;
    }
    public void AdicionarAlunos(Aluno aluno){
        for(int i = 0; i<= meusAlunos.Length; i++){
            if(meusAlunos[i] == null){
                meusAlunos[i] = aluno;
                break;
            }
        }
    }
}