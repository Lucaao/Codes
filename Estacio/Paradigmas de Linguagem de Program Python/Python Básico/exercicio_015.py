diasAlugado = int (input("Quantos dias o carro foi alugado?\n")); 
km = int (input("Quantos KM foram rodados?\n")); 
total = diasAlugado * 60 + km * 0.35; 

print (f"O total a ser pago pelo aluguel do carro será de R${total} reais"); 