valor1 = int (input("Digite um valor: ")); 
valor2 = int (input("Digite outro valor: ")); 
soma = 0; 
multiplicar = 0;  
while True:
    print("-=-" * 10); 
    print("[1] Somar"); 
    print("[2] Multiplicar"); 
    print("[3] Maior"); 
    print("[4] Novos números"); 
    print("[5] Sair do programa!"); 
    opcao = int (input("Selecione uma das opções: ")); 
    print("-=-" * 10); 
    if opcao == 1:
        soma = valor1 + valor2; 
        print(f"A soma de {valor1} e {valor2} é {soma}!"); 
    if opcao == 2:
        multiplicar = valor1 * valor2; 
        print(f"A multiplicação entre {valor1} e {valor2} é {multiplicar}!"); 
    if opcao == 3:
        if valor1 > valor2: 
            print(f"O maior número entre {valor1} e {valor2} é {valor1}"); 
        elif valor1 < valor2: 
            print(f"O maior número entre {valor1} e {valor2} é {valor2}"); 
        elif valor1 == valor2:
            print(f"Os dois números são iguais!"); 
    if opcao == 4:
        valor1 = int (input("Digite um valor: ")); 
        valor2 = int (input("Digite outro valor: ")); 
    if opcao == 5:
        print("Saindo do programa!"); 
        break; 