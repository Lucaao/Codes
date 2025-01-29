#include <stdio.h>
#include <windows.h>
#include <math.h>
#include <string.h>
int main ()

{
UINT CPAGE_UTF8 = 65001;
SetConsoleOutputCP(CPAGE_UTF8);

/*  MAIÚSCULAS E minúsculas */
char nome [10]="Lucas";
strupr(nome);
puts(nome);
strlwr(nome);
puts(nome);
}