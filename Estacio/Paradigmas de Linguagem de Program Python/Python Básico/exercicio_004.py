texto = input ("Digite algo: \n"); 

print (f"O tipo primitivo de {texto} é: {type(texto)}"); 
print (f"{texto} está maíusculo? {texto.isupper()}"); 
print (f"{texto} está minúsculo? {texto.islower()}"); 
print (f"{texto} é alfabético? {texto.isalpha()}"); 
print (f"{texto} é um número? {texto.isnumeric()}"); 
print (f"{texto} é alfanúmerico? {texto.isalnum()}"); 
print (f"{texto} só tem espaços? {texto.isspace()}"); 