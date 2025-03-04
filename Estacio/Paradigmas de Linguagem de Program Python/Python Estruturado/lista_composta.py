# Exercício Python #084 - Lista composta e análise de dados

pessoal = []
dado = []
leve = []
pesado = []
opcao = True 
while opcao is True:
    dado.append(str(input("Nome: "))) 
    dado.append(int(input("Peso: ")))
    pessoal.append(dado[:])
    dado.clear()

    opcao = str(input("Finalizar? [S / N] ").upper())
    if opcao == 'S':
        opcao = False
        print("Finalizando!")
    else:
        opcao = True
        print("-=-" * 15)
for p in pessoal: 
    if p[1] >= 50:
        pesado.append(p[0])
    elif p[1] <=10:
        leve.append(p[0])

print(f"Os cadastrados foram {pessoal}")
print(f"Você cadastrou {len(pessoal)} pessoas!")
print(f"Os mais pesados são: {pesado}")
print(f"Os mais leves são: {leve}")