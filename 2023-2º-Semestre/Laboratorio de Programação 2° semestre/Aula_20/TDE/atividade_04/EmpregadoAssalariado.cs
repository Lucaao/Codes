public class EmpregadoAssalariado : Empregado{
    public override void CalcularSalário(){
        Console.WriteLine($"O Salário do empregado assalariado é {salario}");
    }
}