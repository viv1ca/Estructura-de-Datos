#include <iostream>
using namespace std;

int main() {
    int r = 3, c = 3;
    int arr[9] = {0};
    // matriz inicializada y luego se le asigna un valor

    int twoDArray[3][3] = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    }; // almacenar elementos en un array unidimensional ordenados por filas

    int k = 0;
    for (int y = 0; y < c; y++) {
        for (int x = 0; x < r; x++) {
            k = y * r + x;
            arr[k] = twoDArray[x][y];
            k = k + 1;
        }
    }

    cout << "Los elementos del array son: " << endl;
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            cout << twoDArray[x][y] << " "; // mostrando los elementos de la fila separados por espacios
        }
        cout << endl; // ir a la siguiente linea despues de mostrar una fila
    }

    // Imprimir los elementos del array unidimensional
    cout << "Los elementos del array unidimensional son: " << endl;
    for (int x = 0; x < r; x++) {
        for (int y = 0; y < c; y++) {
            cout << arr[x * c + y] << " ";
        }
    }

    return 0;
}
