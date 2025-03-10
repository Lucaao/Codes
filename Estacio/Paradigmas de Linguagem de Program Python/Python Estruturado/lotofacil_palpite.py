# Exercício Python #088 - Palpites para a Mega Sena / Loto facil

from random import randint
opcao = True
while opcao is True:
    print("-=-" * 25)
    print(f"{'Jogos Lotofacil':^75}")
    print("-=-" * 25)

    contador = 1
    numero_jogos = int(input("Quantos jogos você quer fazer? \n"))
    print()

    jogos = []
    for _ in range(numero_jogos):
        jogo = set()  
        while len(jogo) < 15:
            jogo.add(randint(1, 25))  
        jogos.append(sorted(list(jogo)))  

    for lista in jogos:
        print(f"Jogo Nº{contador}: {lista}")
        contador += 1
    print()
    opcao = str(input("Você deseja fazer mais jogos? [S / N] ")).upper()
    if opcao == "S":
        opcao = True
    elif opcao == "N":
        opcao = False
        print("Ok, Tchau!")
        break
