valor_produto = int (input("Quanto custa o item que você quer comprar? ")); 
print("Você vai pagar este produto como? "); 
print("Opção [1] Á vista dinheiro / cheque: "); 
print("Opção [2] Á vista no cartão: "); 
print("Opção [3] Em até 2x no cartão: "); 
print("Opção [4] 3x ou mais no cartão: "); 
opcao = int (input()); 

if (opcao == 1):
    print(f"O Produto de R${valor_produto}, vai custar R${valor_produto - (valor_produto * 0.10)}"); 
elif (opcao == 2):
    print(f"O Produto de R${valor_produto}, vai custar R${valor_produto - (valor_produto * 0.5)}"); 
elif (opcao == 3):
    print(f"O Produto de R${valor_produto}, vai custar R${valor_produto}"); 
elif (opcao == 4):
    print(f"O Produto de R${valor_produto}, vai custar R${valor_produto + (valor_produto * 0.20)}"); 
else: 
    print("Tu é cego?"); 