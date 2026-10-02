#include <iostream>
using namespace std;

int busqBinaria(int arr[], int l, int h, int elemento) {
    while (l <= h) {
        int mid = l + (h - l) / 2; // Encuentra el índice medio

        // Verifica si el elemento está presente en el medio
        if (arr[mid] == elemento) {
            return mid; // Retorna el índice del elemento encontrado
        }
        // Si el elemento es mayor, ignora la mitad izquierda
        else if (arr[mid] < elemento) {
            l = mid + 1;
        }
        // Si el elemento es menor, ignora la mitad derecha
        else {
            h = mid - 1;
        }
    }
    // Si el control llega hasta aquí, el elemento no está presente en el arreglo
    return -1; // Retorna -1 si el elemento no se encuentra
}

int main() {
    int inputArr[] = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
    int buscarElemento = 20;
    int s = sizeof(inputArr) / sizeof(inputArr[0]);

    // operación de busqueda binaria
    int idx = busqBinaria(inputArr, 0, s - 1, buscarElemento);

    if (idx != -1) {
        cout << "El elemento se encuentra en la posición: " << (idx + 1) << endl; // Suma 1 para mostrar la posición en base 1
    } else {
        cout << "No se encuentra el elemento." << endl;
    }

    return 0;
}
