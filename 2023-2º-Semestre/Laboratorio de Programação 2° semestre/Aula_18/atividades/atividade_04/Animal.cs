class Animal{
    public string? nome{get;set;}
    public int idade{get;set;}
    protected int numeroDePatas;
    public virtual string EmitirSom(){
        return "som de um animal";
    }
    protected virtual int ExibirNumeroDePatas(){
        return numeroDePatas;
    }
}