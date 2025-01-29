/* Exercício 4: Polimorfismo com Coleções
Crie uma lista de Animal e adicione várias instâncias de Cachorro e Gato. Itere sobre a lista e invoque o método EmitirSom() para cada animal. 
Observe como o comportamento polimórfico permite que diferentes tipos de animais emitam seus sons característicos. */

List<Animal> animals = new List<Animal>();

animals.Add(new Cachorro("Perseus", 10));
animals.Add(new Cachorro("Farid", 6));
animals.Add(new Gato("Plinio", 12));
animals.Add(new Gato("Pomo", 3));
animals.Add(new Cachorro("Afonço", 2));
animals.Add(new Cachorro("Alfred", 9));
animals.Add(new Gato("Pomodoro", 5));
animals.Add(new Gato("Louvre", 1));

foreach (Animal animais in animals){
    Console.WriteLine($"{animais.EmitirSom()}");
    Console.WriteLine();
}