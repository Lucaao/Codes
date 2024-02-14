/* Hierarquia Animal:
Crie uma classe abstrata Animal com um método abstrato FazerSom.
Derive pelo menos duas classes concretas (como Cachorro e Gato) e implemente o método FazerSom. */

Gato gato1 = new Gato();
gato1.nome = "Astolfo";
gato1.FazerSom();

Cachorro cachorro1 = new Cachorro();
cachorro1.nome = "Alfred";
cachorro1.FazerSom();