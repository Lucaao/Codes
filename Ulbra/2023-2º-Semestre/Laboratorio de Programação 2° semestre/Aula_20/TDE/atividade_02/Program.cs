/* Calculadora de Formas:
Defina uma classe abstrata Forma com um método abstrato CalcularÁrea.
Crie classes derivadas como Círculo e Retângulo, implementando o método CalcularÁrea. */

Retangulo r1 = new Retangulo(2, 3, 'A');  /* Parametros INT - INT - CHAR */
r1.CalcularArea();

Retangulo r2 = new Retangulo(5, 10, 'B'); /* Parametros INT - INT - CHAR */
r2.CalcularArea();

Circulo c1 = new Circulo(3, 'A'); /* Parametros INT - CHAR */
c1.CalcularArea();

Circulo c2 = new Circulo(5, 'B'); /* Parametros INT - CHAR */
c2.CalcularArea();