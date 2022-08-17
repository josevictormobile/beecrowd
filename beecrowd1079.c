#include <stdio.h>

int main() {

    int n;
    scanf("%d",&n);
    float resultados[n];
    float x,y,z;
    float resultado;
    for(int i=0;i<n;i++){
        scanf("%f %f %f", &x, &y, &z);
        resultado = (x*2+y*3+z*5)/10;
        resultados[i]=resultado;
    }
    for(int i=0;i<n;i++){
        printf("%.1f\n",resultados[i]);
    }

    return 0;
}
