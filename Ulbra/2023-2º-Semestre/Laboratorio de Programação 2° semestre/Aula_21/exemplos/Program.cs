/* Exemplos Aula 21 */

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