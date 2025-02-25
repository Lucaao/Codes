# Exercício Python #077 - Contando vogais em Tupla

palavras = (
    "aprender", "batata", "arroz", "carro", "muito", "rapido"
)

for p in palavras: 
    print(f"\nNa palavra {p.upper()} temos ", end= ""); 
    for letra in p:
        if letra.lower() in "aeiou": 
            print(f"{letra} ", end = ""); 