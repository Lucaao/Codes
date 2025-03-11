#Exercício Python #089 - Boletim com listas compostas
ficha = []
num = 1
while True: 
    id = num
    num += 1
    nome = str(input("Digite seu nome: "))
    nota1 = float(input("Digite sua 1º nota: "))
    nota2 = float(input("Digite sua 2º nota: "))
    media = (nota1 + nota2) / 2
    ficha.append([id, nome, [nota1, nota2], media])
    if input("Quer continuar? [S / N] ").upper() != "S":
        print("-" * 35)
        break
print(f"{"No.":<5}{"NOME":<20}{"MÉDIA":<10}")
print("-" * 35)
for a in ficha: 
    print(f"{a[0]:<5}{a[1]:<20}{a[3]}")
print("-" * 35)
while True:
    opcao = int(input("Mostrar notas de qual aluno? [999 - Encerra] "))
    if opcao == 999:
        print("Encerrando!")
        break
    elif opcao <= len(ficha) and opcao > 0:
        print(f"Notas de {ficha[opcao-1][1]} são {ficha[opcao-1][2]}")