class Gato : Animal{
    public override string EmitirSom(){
        return $"O {nome} esta miando e tem {numeroDePatas} patas.";
    }
    public Gato (string nome, int idade, int numeroDePatas){
        this.nome = nome;
        this.idade = idade;
        this.numeroDePatas = numeroDePatas;
    }
}