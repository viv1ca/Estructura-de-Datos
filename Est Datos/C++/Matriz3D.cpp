#include <iostream>
using namespace std;

int main() {
    // Matriz 3D
    int threeDimensionalArray[2][3][3] = { // Guarda 2 arreglos bidimensionales
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8}
        },
        {
            {9, 10, 11},
            {12, 13, 14},
            {15, 16, 17}
        }
    };

    cout << "Los elementos del array son: " << endl;
    for (int block = 0; block < 2; block++) { // Recorre cada arreglo bidimensional
        for (int row = 0; row < 3; row++) {
            for (int col = 0; col < 3; col++) {
                cout << threeDimensionalArray[block][row][col] << " "; // mostrando los elementos de la fila separados por espacios
            }
            cout << endl; // ir a la siguiente linea despues de mostrar una fila
        }
        cout << endl;
    }

    return 0;
}
