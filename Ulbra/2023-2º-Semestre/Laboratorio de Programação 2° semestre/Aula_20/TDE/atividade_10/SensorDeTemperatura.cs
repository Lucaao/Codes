public class SensorDeTemperatura : ISensor{
    public void LerValor(double valor){
        Console.WriteLine($"O sensor detectou {valor} Cº de temperatura!");
    }
}