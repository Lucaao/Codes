times = ("Corinthians", "Flamengo", "Palmeiras", 
        "Internacional", "Gremio"); 

print("-=-" * 25); 
print(f"Lista de times do Brasileirão: {times}"); 
print("-=-" * 25);  
print(f"Lista dos 2 primeiros times do Brasileirão: {times[0:2]}"); 
print("-=-" * 25); 
print(f"Lista dos ultimos 2 times do Brasileirão: {times[-2:]}"); 
print("-=-" * 25); 
print(f"Lista de times do Brasileirão em ordem Alfabética: {sorted(times)}"); 
print("-=-" * 25); 
print(f"O Internacional está na {times.index("Internacional")} posição!"); 
print("-=-" * 25); 
