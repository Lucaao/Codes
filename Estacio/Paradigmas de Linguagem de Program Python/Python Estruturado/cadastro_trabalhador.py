# Exercício Python #092 - Cadastro de Trabalhador em Python
from datetime import datetime
print(f"-" * 30)
print(f"{"Cadastrando trabalhador!":^30}")
print(f"-" * 30)

cadastro = dict()
cadastro['Nome'] = input("Digite o seu nome: ")
cadastro['Nascimento'] = int(input("Ano de nascimento: "))
cadastro['Idade'] = datetime.now().year - cadastro['Nascimento']
cadastro['CTPS'] = int(input("Digite sua carteira de trabalho: [0] Não tem "))

if cadastro['CTPS'] != 0:
    cadastro['Ano de contratação'] = int(input("Ano da 1º contratação: "))
    cadastro['Salario'] = int(input("Valor do seu salário: "))
    cadastro['Anos para aposentadoria'] = cadastro['Idade'] + (cadastro['Ano de contratação'] + 35) - datetime.now().year
    print(f"-" * 30)
else:
    cadastro['CTPS'] = "Não tem"
print(f"{"Trabalhador!":^30}")
print(f"-" * 30)
for k, v in cadastro.items():
    print(f"{k}: {v}")
print(f"-" * 30)