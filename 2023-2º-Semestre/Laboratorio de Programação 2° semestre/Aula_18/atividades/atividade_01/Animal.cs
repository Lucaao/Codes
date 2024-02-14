class Animal{
    public string? nome{get;set;}
    public int idade{get;set;}
    public virtual string EmitirSom(){
        return "som de um animal";
    }
}