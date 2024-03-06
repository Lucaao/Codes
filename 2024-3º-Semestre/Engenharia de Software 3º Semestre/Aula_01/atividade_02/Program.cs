/* Atividade 2: Modelagem de Praia

Considere o seguinte cenário:

Imagine que estamos desenvolvendo um aplicativo turístico e precisa representar a entidade Praia. 
Crie uma classe chamada Praia na linguagem que preferir com os seguintes atributos: nome, localizacao, temperaturaAgua e tipoAreia. 
Adicione um método chamado informacoesPraia que retorna uma string com todas as informações da praia. 
Em seguida, crie uma instância dessa classe e utilize o método informacoesPraia para exibir os detalhes da praia.
 */

// Instância com parâmetros da PRAIA 1
Praia p1 = new Praia("Real", "Madrid - Espanha", 25, "Fina e Preta");
p1.informacoesPraia();

// Instância com parâmetros da PRAIA 2
Praia p2 = new Praia("Beldora", "Barcelona - Espanha", 31, "Densa e Amarela");
p2.informacoesPraia();