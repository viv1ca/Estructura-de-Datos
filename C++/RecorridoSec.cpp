#include <iostream>
using namespace std;

int main() {
    // Recorrer un arreglo de forma secuencial
    int inputArr[] = {5, 10, 15, 20, 25, 30};
    int n = sizeof(inputArr) / sizeof(inputArr[0]);

    cout << "Recorrido secuencial del arreglo:" << endl;

    for (int i = 0; i < n; i++) {
        cout << inputArr[i] << " ";
    }

    return 0;
}
