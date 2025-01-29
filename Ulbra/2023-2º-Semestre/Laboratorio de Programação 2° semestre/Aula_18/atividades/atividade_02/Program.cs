/*Exercício 2: Construtores e Herança
Descrição:
Amplie o exercício anterior adicionando construtores em Animal, Cachorro e Gato.
O construtor de cada classe deve definir as propriedades Nome e Idade apropriadas. 
Certifique-se de que as classes derivadas chamem o construtor da classe base com a palavra-chave base. */

Cachorro cachorro1 = new Cachorro ("Perseus", 10); // Cria nome e idade do cachorro
Console.WriteLine(cachorro1.EmitirSom()); // Faz o cachorro emitir som

Gato gato1 = new Gato ("Farid", 6); // Cria nome do gato
Console.WriteLine(gato1.EmitirSom());
