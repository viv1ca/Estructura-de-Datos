#include <iostream>
using namespace std;

int main() {
    // Recorrido matriz 2D
    int twoDimensionalArray[3][3] = {
        {1, 2, 3},
        {4, 5, 6},
        {7, 8, 9}
    };
    cout << "Los elementos del array son:" << endl;
    for (int row = 0; row < 3; row++) {
        for (int col = 0; col < 3; col++) {
            cout << twoDimensionalArray[row][col] << " "; // mostrando los elementos de la fila separados por espacios
        }
        cout << endl; // Ir a la siguiente linea despues de mostrar una fila
    }

    return 0;
}
