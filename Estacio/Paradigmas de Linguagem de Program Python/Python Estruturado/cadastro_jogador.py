# Exercício Python #093 - Cadastro de Jogador de Futebol
print("-" * 30)
print(f"{"Aproveitamento jogador de futebol!":30}")
print("-" * 30)

aproveitamento = dict()
partidas = []
aproveitamento['Nome do jogador'] = input("Digite o nome do jogador: ")
total_partidas = int(input(f"Quantas partidas o {aproveitamento['Nome do jogador']} jogou: "))
for n in range(0, total_partidas):
    partidas.append(int(input(f" Quantos gols na partida {n+1}? ")))
aproveitamento['Gols'] = partidas[:]
aproveitamento['Total'] = sum(partidas)
print(f"-" * 30)
print(f"{"Aproveitamento do jogador!":^30}")
print(f"-" * 30)
for k, v in aproveitamento.items():
    print(f"{k}: {v}")
print(f"-" * 30)