#include <stdio.h>

int main()
{

    int entradas[100];
    int maior, indice = 0;
    for (int i = 0; i < 100; i++)
    {
        scanf("%d",&entradas[i]);
    }
    maior = entradas[0];
    for (int i = 0; i < 100; i++)
    {
        if (entradas[i] > maior)
        {
            maior = entradas[i];
            indice = i;
        }
    }
    printf("%d",maior);
    printf("%d",indice);

    return 0;
}