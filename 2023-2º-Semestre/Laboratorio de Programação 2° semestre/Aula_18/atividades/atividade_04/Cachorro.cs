class Cachorro : Animal{
    public override string EmitirSom(){
        return $"O {nome} esta latindo e tem {numeroDePatas} patas.";
    }
    public Cachorro(string nome, int idade){
        this.nome = nome;
        this.idade = idade;
        this.numeroDePatas = 4;
    }
}