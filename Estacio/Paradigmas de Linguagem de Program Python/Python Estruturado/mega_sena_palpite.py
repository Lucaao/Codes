# Exercício Python #088 - Palpites para a Mega Sena / Loto facil
from random import randint
print("-=-" * 15)
contador = 1; 
numero_jogos = int(input("Quantos jogos você quer fazer? "))
jogos = [[randint(1,60) for n in range(6)]for n in range(numero_jogos)]

for lista in jogos:
    print(f"Jogo Nº{contador}: {lista}")
    contador += 1