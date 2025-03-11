# Exercício Python #091 - Jogo de Dados em Python
from random import randint
from time import sleep
from operator import itemgetter
i = 1
jogadores = dict()
for p in range(0,4):
    jogador = f"Jogador {p+1}"
    jogadores[jogador] = randint(1,6)
    sleep(1)
    print(f"{jogador} tirou {jogadores[jogador]}")
print("-" * 30)
print(f"{"Ranking":^30}")
print("-" * 30)
ranking = sorted(jogadores.items(), key=itemgetter(1), reverse=True)
for i, v in enumerate(ranking):
    print(f"{i+1}ºLugar {v[0]} Pontos: {v[1]}")
print("-" * 30)
