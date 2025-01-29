class Cachorro : Animal{
    public override string EmitirSom(){
        return $"O {nome} esta latindo e tem {numeroDePatas} patas.";
    }
    public Cachorro(string nome, int idade, int numeroDePatas){
        this.nome = nome;
        this.idade = idade;
        this.numeroDePatas = numeroDePatas;
    }
}