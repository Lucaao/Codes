# Exercício Python #094 - Unindo dicionários e listas
pessoa = dict()
pessoas = []
soma = media = 0
while True:
    print("-" * 30)
    print(f"{"Cadastrando pessoa!":^30}")
    print("-" * 30)
    pessoa['Nome'] = input("Digite seu nome: ")
    while True:
        pessoa['Sexo'] = str(input("Digite seu sexo: [M / F] ")).upper()[0]
        if pessoa["Sexo"] in 'MF':
            break
        else:
            print("ERRADO! Digite apenas M ou F")
    pessoa['Idade'] = int(input("Digite sua idade: "))
    soma += pessoa["Idade"]
    pessoas.append(pessoa.copy())
    pessoa.clear()
    opcao = input("Deseja cadastrar mais pessoas? [S / N] ").upper()
    if opcao == 'N':
        print("Encerrando!")
        break
    else:
        print('')
media = soma / len(pessoas)
print("-" * 30)
print(f"{"CADASTRO!":^30}")
print("-" * 30)
print(f"Foram cadastradas {len(pessoas)} pessoas!")
print(f"A média de idade é de {media} anos!")
print(f"As mulheres cadastradas foram ", end='')
for p in pessoas:
    if p['Sexo'] == 'F':
        print(f"{p['Nome']}", end=' ')
print("")
print("Pessoas com idade acima da média:"),
for p in pessoas:
    if p['Idade'] >= media:
        print("")
        for k, v in p.items():
            print(f"{k}: {v}")
print("-" * 30)