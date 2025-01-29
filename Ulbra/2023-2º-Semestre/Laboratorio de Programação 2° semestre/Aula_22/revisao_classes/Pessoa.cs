public abstract class Pessoa {
    public string? Endereco { get; set; }
    public string? Telefone { get; set; }
    public string? Nome { get; set; }
    protected int NumeroConta { get; set; }
    public int getNumeros(){
        return NumeroConta;
    }
    public virtual void Salvar(){
        Console.WriteLine("Salvando pessoa!");
    }
    public abstract void Excluir();
}