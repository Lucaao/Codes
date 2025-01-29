class ConversorTemperatura {
    public double temperaturaCelsius;
    public void ConverterParaFahrenheit(){
        double conversao = (temperaturaCelsius * 1.8) + 32;
        Console.WriteLine($"A temperatura em Fahrenheit é {conversao} F");
    }
}