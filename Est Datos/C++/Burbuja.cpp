#include <iostream>
using namespace std;

void bubbleSort(int a[], int s) {
    // iterando por todos los elementos del arreglo
    for (int i = 0; i < s; i++) {
        bool isSwapped = false;
        // los ultimos i elementos ya están en su lugar correspondiente
        for (int j = 0; j < s - i - 1; j++) {
            // recorriendo por el arreglo de 0 a s-i-1
            // intercambiando si el elemento encontrado es mayor que el siguiente elemento
            if (a[j] > a[j + 1]) {
                swap(a[j], a[j + 1]);
                isSwapped = true;
            }
        }
        if (!isSwapped) break;
    }
}

int main() {
    int a[] = {70, 15, 2, 51, 60};
    int s = sizeof(a) / sizeof(a[0]);

    cout << "Antes de ordenar los elementos del arreglo son: " << endl;
    for (int i = 0; i < s; i++) cout << a[i] << " ";

    bubbleSort(a, s);

    cout << "\nDespués de ordenar los elementos del arreglo: " << endl;
    for (int i = 0; i < s; i++) cout << a[i] << " ";

    return 0;
}
