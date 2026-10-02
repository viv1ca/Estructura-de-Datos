#include <iostream>
#include <vector>
using namespace std;

int main() {
    // Eliminación de un elemento en un indice específico de un arreglo
    vector<int> inputArr = {5, 10, 15, 20, 25, 30};
    int position = 3; // Índice del elemento a eliminar
    cout << "Antes de la eliminación, el array es: " << endl;
    for (int i : inputArr) cout << i << " ";
    cout << endl; // Imprime una línea en blanco

    // Elimina el elemento en la posición especificada
    if (position >= 0 && position < (int)inputArr.size()) {
        inputArr.erase(inputArr.begin() + position);

        cout << "Después de la eliminación, el array es: " << endl;
        for (int i : inputArr) cout << i << " ";
    } else {
        cout << "Índice fuera de rango" << endl;
    }
    cout << endl;

    return 0;
}
