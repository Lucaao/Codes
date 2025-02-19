from random import randint
print("-=-" * 15); 
print("5 números aleatórios, maior e menor!"); 
num = tuple([randint(0,10) for num in range (0,5)])
print(num); 
print(f"Maior número: {max(num)}"); 
print(f"Menor número: {min(num)}"); 
print("-=-" * 15); 
