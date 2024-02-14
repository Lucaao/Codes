class Cachorro : Animal{
    public override string EmitirSom(){
        return $"O {nome} esta latindo!";
    }
    public Cachorro(string nome, int idade){
        this.nome = nome;
        this.idade = idade;
    }
}