/* Exercício 8: Classe TimeFutebol
Crie uma classe TimeFutebol com os atributos nome, cidade e anoFundacao. 
Crie dois objetos com atributos diferentes e mostre-os no console. */

TimeFutebol time1 = new TimeFutebol ();
time1.nome = "Aimoré";
time1.cidade = "São Leopoldo";
time1.anoFundacao = 2018;

TimeFutebol time2 = new TimeFutebol ();
time2.nome = "Caxias";
time2.cidade = "Caxias do Sul";
time2.anoFundacao = 2015;
Console.WriteLine($"{time1.nome}, {time1.cidade}, {time1.anoFundacao}. \n{time2.nome}, {time2.cidade}, {time2.anoFundacao}.");
public class TimeFutebol {
    public string? nome;
    public string? cidade;
    public double anoFundacao;
}