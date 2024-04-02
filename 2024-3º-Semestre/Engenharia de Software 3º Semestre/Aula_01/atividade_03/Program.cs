/* Atividade 3: Sistema de Reservas de Voos

Considere o seguinte cenário:

Você está desenvolvendo um sistema de reservas de voos e precisa modelar a entidade Voo. 
Crie uma classe chamada Voo na linguagem que preferir que represente a estrutura de um voo. 
A classe deve ter os seguintes atributos: companhiaAerea, origem, destino, dataPartida e precoPassagem. 
Adicione um método chamado informacoesVooque retorne uma string com todas as informações do voo. 
Crie uma instância dessa classe, atribuindo valores aos atributos, e utilize o método informacoesVoo para exibir os detalhes do voo. */

// Instancia do Voo1 com parâmetros
Voo Voo1 = new Voo ("Latam", "Porto Alegre - RS", "São Paulo - SP", "25/03/2024", 880);
Voo1.informacoesVoo();

// Instancia do Voo2 com parâmetros
Voo Voo2 = new Voo ("Gol", "Rio de Janeiro - RJ", "Belo Horizonte - MG", "10/03/2024", 660);
Voo2.informacoesVoo();