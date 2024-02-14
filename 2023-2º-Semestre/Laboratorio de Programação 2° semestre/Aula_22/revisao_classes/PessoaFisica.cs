public class PessoaFisica : Pessoa, IPessoa {
    public string? Cpf { get; set; }
    public int Rg { get; set; }

    public PessoaFisica(){
        NumeroConta = 0000;
    }
    public void AbrirConta(){
        Console.WriteLine("Abrindo conta!");
    }
    public void FecharConta(){
        Console.WriteLine("Fechando conta!");
    }
    public void Salvar(string algum){
        Console.WriteLine($"Salvando {algum}!");
    }
    public override void Excluir(){
        Console.WriteLine("Excluindo pessoa fisica!");
    }
}