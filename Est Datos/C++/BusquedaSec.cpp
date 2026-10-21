#include <iostream>
using namespace std;

int busqSecuencial(int arr[], int s, int elemento) {
    for (int i = 0; i < s; i++) {
        if (arr[i] == elemento) { // Aplicando busqueda lineal
            return i; // Retorna el índice del elemento encontrado
        }
    }
    return -1; // Retorna -1 si el elemento no se encuentra
}

int main() {
    int inputArr[] = {5, 10, 15, 20, 25, 30};
    int searchElement;
    cout << "Ingrese el elemento a buscar: ";
    cin >> searchElement;
    int size = sizeof(inputArr) / sizeof(inputArr[0]);

    // operación de busqueda secuencial
    int idx = busqSecuencial(inputArr, size, searchElement);

    if (idx != -1) {
        cout << "El elemento se encuentra en la posición: " << (idx + 1) << endl; // Suma 1 para mostrar la posición en base 1
    } else {
        cout << "No se encuentra el elemento." << endl;
    }

    return 0;
}
