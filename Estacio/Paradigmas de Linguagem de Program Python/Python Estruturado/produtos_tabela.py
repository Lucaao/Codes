# Exercício Python #076 - Lista de Preços com Tupla

prod_preco = ("Batata", 3.50, 
              "Pão", 2, 
              "Polenta", 1, 
              "Refri", 5, 
              "Cenoura", 1.25,
              "Presunto", 5.20); 
print("-" * 39); 
print(f"{'Produtos / Valor':^39}"); 
print("-" * 39); 
for pos in range(0, len(prod_preco)):
    if pos % 2 == 0: 
        print(f"{prod_preco[pos]:<30}", end = ''); 
    else:
        print(f"R${prod_preco[pos]:>7.2f}"); 
print("-" * 39); 