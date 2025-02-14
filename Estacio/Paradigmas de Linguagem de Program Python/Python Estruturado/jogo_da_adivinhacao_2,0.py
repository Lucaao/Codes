from random import randint
palpite = 1; 
print("-==-" *20); 
print("Vou pensar em um número de 0 a 10 e você deve tentar adivinhar:"); 
numero = randint (0,10); 
print("Pensando..."); 
while True:
    resposta = int (input("Qual número eu pensei?\n")); 
    if resposta == numero: 
        print(f"Parabens! Você acertou o número [{numero}]!"); 
        print(f"Você acertou em {palpite} tentativa(s)!"); 
        break; 
    else: 
        palpite += 1; 
        print(f"Você errou, pensei no número {numero}! \ne não no {resposta}."); 
    print("-==-" *20);  