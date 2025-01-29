/* Hierarquia de Empregados:
Crie uma classe abstrata Empregado com um método abstrato CalcularSalário.
Crie subclasses como EmpregadoHorista e EmpregadoAssalariado, implementando CalcularSalário. */

EmpregadoHorista EH1 = new EmpregadoHorista(150);
EH1.CalcularSalário();

EmpregadoAssalariado EA1 = new EmpregadoAssalariado();
EA1.CalcularSalário();