public class EmpregadoHorista : Empregado{
    public int adicional;
    public EmpregadoHorista(int Adicional){
        this.adicional = salario + Adicional;
    }
    public override void CalcularSalário(){
        Console.WriteLine($"O salário do empregado horista vai ser {adicional}.");
    }
}