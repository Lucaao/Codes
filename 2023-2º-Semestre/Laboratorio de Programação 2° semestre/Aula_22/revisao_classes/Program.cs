/* Exemplos revisão 
ABSTRACT - OVERRIDE - HERANÇA - POLIMORFISMO/SOBRECARGA DE MÉTODO - ENCAPSULAMENTO */


PessoaFisica PF1 = new PessoaFisica();
PF1.Nome = "Arnaldo";
PF1.Cpf = "434.123.430-01";
PF1.Endereco = "Rua Tonhão Brás";
PF1.Salvar();
PF1.Salvar("Pessoa Fisica");

PessoaJuridica PJ1 = new PessoaJuridica();
PJ1.Nome = "Tonhão";
PJ1.Cnpj = "301/12312/19.01";
PJ1.Endereco = "Rua dos cunha";
PJ1.Telefone = "(55) 51 98535-7394";
PJ1.Salvar();
Console.WriteLine(PJ1.getNumeros());
