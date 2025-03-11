# Exercício Python #090 - Dicionário em Python
aluno = dict()

aluno['Nome'] = input("Digite seu nome: ")
aluno['Media'] = int(input("Digite sua média: "))
if aluno['Media'] > 6:
    aluno['Situação'] = "Aprovado!"
elif aluno['media'] < 3:
    aluno['Situação'] = "Reprovado!"
else:
    aluno['Situação'] = "Reprovado!"
for k, v in aluno.items():
    print(f"{k} = {v}")