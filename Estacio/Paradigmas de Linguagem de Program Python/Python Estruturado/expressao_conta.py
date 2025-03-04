# Exercício Python #083 - Validando expressões matemáticas
print("Exemplo: ((2-2) * (3+5))")
expressao = str(input("Digite uma expressão! [0] Finalizar! "))
parenteses = []
for simb in expressao:
    if simb == "(": 
        parenteses.append("(")
    elif simb == ")":
        if len(parenteses) > 0:
            parenteses.pop()
        else:
            parenteses.append(")")
            break
if len(parenteses) == 0: 
    print("A sua expressão está correta!")
else:
    print("A sua expressão está incorreta!")