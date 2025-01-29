#include <stdio.h>
#include <windows.h>
#include <math.h>
#include <time.h>
#define MAX 10
int main()

{
    UINT CPAGE_UTF8 = 65001;
    SetConsoleOutputCP(CPAGE_UTF8);

    int valor, existe, vetor[MAX] = {0}, i = 0, n;
    while (i < MAX){
        printf("Digite o valor da posição %d: ", i+1);
        scanf("%d", &valor);
        for (n = existe = 0; n < i; n++)
            if (vetor[n] == valor)
                existe = 1;
        if (existe){
            printf("O valor %d já existe\n", valor);
        }else{
            vetor[i++] = valor;
        }
    }
    printf("Vetor:\n");
    for(i = 0; i < MAX; i++){
        printf("%d\n", vetor[i]);
    }
    return 0;
}