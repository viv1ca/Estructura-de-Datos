#include <iostream>
using namespace std;

int main() {
    // Recorrer un arreglo de forma inversa
    int inputArr[] = {5, 10, 15, 20, 25, 30};
    int n = sizeof(inputArr) / sizeof(inputArr[0]);

    cout << "Recorrido inverso del arreglo:" << endl;

    for (int i = n - 1; i >= 0; i--) {
        cout << inputArr[i] << " ";
    }

    return 0;
}
