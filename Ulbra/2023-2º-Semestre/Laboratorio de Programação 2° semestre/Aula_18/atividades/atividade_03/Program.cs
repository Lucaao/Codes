/* Exercício 3: Propriedades e Métodos Protegidos
Na classe base Animal, adicione uma propriedade protegida NumeroDePatas e um método protegido ExibirNumeroDePatas() que imprime o número de patas. 
Nas classes derivadas, configure esta propriedade no construtor e chame o método ExibirNumeroDePatas() dentro do método EmitirSom(). */

Cachorro cachorro1 = new Cachorro ("Perseus", 10, 4); // Cria nome e idade do cachorro
Console.WriteLine(cachorro1.EmitirSom()); // Faz o cachorro emitir som

Gato gato1 = new Gato ("Farid", 6, 4); // Cria nome do gato
Console.WriteLine(gato1.EmitirSom());