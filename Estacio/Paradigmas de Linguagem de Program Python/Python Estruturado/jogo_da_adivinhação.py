from random import randint

print("-==-" *20); 
print("Vou pensar em um número de 0 a 5 e você deve tentar adivinhar:"); 
numero = randint (0,5); 
print("Pensando..."); 
resposta = int (input("Qual número eu pensei?\n")); 
if resposta == numero: 
    print(f"Parabens. você acertou o número!"); 
else: 
    print(f"Você errou, pensei no número {numero}! \ne não no {resposta}."); 
print("-==-" *20);  