public class SensorDePressão : ISensor{
    public void LerValor(double valor){
        Console.WriteLine($"O Sensor mediu {valor}º de pressão!");
    }
}