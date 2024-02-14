public class ArmazenamentoBD : IRepositorioDeDados{
    public void Salvar(string dados){
        Console.WriteLine("Salvando no banco de dados!");
    }
    public string Carregar(){
        return "Carregando dados no banco de dados!";
    }
}
