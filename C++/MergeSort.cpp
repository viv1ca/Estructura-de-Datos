#include <iostream>
using namespace std;

void merge(int a[], int l, int m, int r) {
    int a1 = m - l + 1; // Tamaño del primer array
    int a2 = r - m; // Tamaño del segundo subarray
    // crear arrays temporales
    int* L = new int[a1];
    int* R = new int[a2];

    // copiar datos a los arrays temporales
    for (int j = 0; j < a1; j++) {
        L[j] = a[l + j];
    }

    for (int k = 0; k < a2; k++) {
        R[k] = a[m + 1 + k];
    }

    int i = 0; // indice inicial del primer sub array
    int j = 0; // indice inicial del segundo sub array
    int k = l; // indice inicial del sub array mezclado

    // Mezclar los arrays temporales de nuevo en a[l...r]
    while (i < a1 && j < a2) { // recorre ambos arrays
        if (L[i] <= R[j]) { // comparar los elementos de ambos arrays
            a[k] = L[i]; // copiar el elemento más pequeño al array original
            i = i + 1;
        }
        // Copiar los elementos restantes de R[] si hay alguno
        else {
            a[k] = R[j]; // copiar el elemento del array original
            j = j + 1;
        }
        k = k + 1; // Incrementar el indice del array original
    }
    while (i < a1) { // copiar los elementos restantes de L
        a[k] = L[i];
        i = i + 1;
        k = k + 1;
    }
    while (j < a2) { // copiar los elementos restantes del segundo array
        a[k] = R[j]; // copiar el elemento del array original
        j = j + 1; // incrementar el indice del segundo array
        k = k + 1; // Incrementar el indice del array original
    }
    // l es para el indice izquierdo y r es para el indice derecho del sub array de "a" a ser ordenado

    delete[] L;
    delete[] R;
}

void mergeSort(int a[], int l, int r) { // Función principal que ordena a[l...r]
    if (l < r) { // Igual que (l + r)/2, pero evita el desbordamiento para grandes valores de l y h
        int m = l + (r - l) / 2;
        // ordenar la primera y segunda mitad
        mergeSort(a, l, m); // Ordenar la primera mitad
        mergeSort(a, m + 1, r); // ordenar la segunda mitad
        merge(a, l, m, r); // Mezclar las dos mitades
    }
}

// Divide el array en dos mitades, las ordena y luego las mezcla
int main() {
    int a[] = {12, 11, 13, 5, 6, 7}; // arreglo desordenado
    int s = sizeof(a) / sizeof(a[0]);

    cout << "Arreglo antes de ser ordenado: " << endl;
    for (int j = 0; j < s; j++) {
        cout << a[j] << " "; // imprime el arreglo
    }

    mergeSort(a, 0, s - 1); // llamada a la función mergeSort

    cout << "\nArreglo después de ser ordenado: " << endl;
    for (int j = 0; j < s; j++) {
        cout << a[j] << " "; // imprime el arreglo
    }

    return 0;
}
