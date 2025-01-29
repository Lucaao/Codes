class Gato : Animal{
    public override string EmitirSom(){
        return $"O {nome} esta miando";
    }
    public Gato (string nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }
}