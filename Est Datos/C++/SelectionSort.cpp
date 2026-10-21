#include <iostream>
using namespace std;

void selection(int a[], int n) { // función para implementar el algoritmo de selección
    for (int i = 0; i < n; i++) { // recorre todo el arreglo
        int small = i; // indice del elemento más pequeño
        for (int j = i + 1; j < n; j++) { // encuentra el elemento más pequeño
            if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                small = j; // actualiza el índice del elemento más pequeño
            }
        }
        swap(a[i], a[small]); // intercambia los elementos
    }
}

void printArr(int a[], int n) { // función para imprimir el array
    for (int i = 0; i < n; i++) { // recorre todo el arreglo
        cout << a[i] << " "; // imprime el elemento
    }
}

int main() {
    int a[] = {65, 26, 13, 23, 12}; // arreglo desordenado
    int n = sizeof(a) / sizeof(a[0]);
    cout << "Arreglo antes de ser ordenado: " << endl;
    printArr(a, n);
    selection(a, n);
    cout << "\nArreglo después de ser ordenado: " << endl;
    selection(a, n);
    printArr(a, n);

    return 0;
}
