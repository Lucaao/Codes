print("-=-" * 15); 
print("Armazenando produtos com valor!"); 
print("-=-" * 15); 
soma_produtos = 0; 
maior1000 = 0; 
menor_produto = None; 
nome = ''; 
while True:
    produto = str (input("Digite o nome do produto: ")); 
    valor = int (input("Digite o valor deste produto: ")); 
    soma_produtos += valor; 

    if valor > 1000:
        maior1000 += 1; 

    if menor_produto is None or valor < menor_produto: 
        menor_produto = valor; 
        nome = produto; 

    opcao = str (input("Você deseja continuar? [S / N] ")); 
    if opcao == "S":
        print("Continuando!"); 
    elif opcao == "N": 
        print("Finalizando!")
        break; 
    else: 
        print("Opção inválida!\nTente novamente!"); 
print(f"O produto com menor valor é {nome}, e o valor dele é R${menor_produto}."); 
print(f"{maior1000} produtos estão valor acima de R$1.000,00"); 
print(f"O total gasto foi de R${float(soma_produtos)} reais."); 
print("-=-" * 15); 