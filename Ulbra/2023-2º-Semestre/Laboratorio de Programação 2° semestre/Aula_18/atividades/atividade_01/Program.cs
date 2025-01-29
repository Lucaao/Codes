/* Exercício 1: Hierarquia Básica de Classes
Crie uma classe base chamada Animal com propriedades Nome e Idade e um método EmitirSom(). 
Em seguida, crie duas classes derivadas: Cachorro e Gato. 
Sobrescreva o método EmitirSom() para que o Cachorro emita um latido e o Gato um miado. */

Cachorro cachorro1 = new Cachorro {nome = "Perseus", idade = 5}; // Cria nome e idade do cachorro
Console.WriteLine(cachorro1.EmitirSom()); // Faz o cachorro emitir som

Gato gato1 = new Gato {nome = "Bid", idade = 10}; // Cria nome do gato
Console.WriteLine(gato1.EmitirSom());
