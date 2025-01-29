public class ArmazenamentoEmArquivos : IRepositorioDeDados {
    public void Salvar(string dados){
        Console.WriteLine("Salvando em arquivos!");
    }
    public string Carregar(){
        return "Carregando dados no arquivo!";
    }
}