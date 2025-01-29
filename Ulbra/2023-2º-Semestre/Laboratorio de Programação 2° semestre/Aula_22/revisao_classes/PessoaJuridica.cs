public class PessoaJuridica : Pessoa {
    public string? Cnpj { get; set; }
    public PessoaJuridica(){
        NumeroConta = 1111;
    }
    public override void Salvar(){
        Console.WriteLine("Salvando pessoa juridica!");
    }
    public override void Excluir(){
        Console.WriteLine("Excluindo pessoa juridica!");
    }
}