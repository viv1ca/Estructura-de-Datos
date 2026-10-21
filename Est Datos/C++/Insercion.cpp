#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> inputArr = {10, 15, 20, 25, 30};
    cout << "Antes de la inserción, el array es:" << endl;
    for (int i : inputArr) cout << i << " ";

    inputArr.insert(inputArr.begin(), 5); // Inserta el elemento 5 al inicio del arreglo (indice, valor)

    cout << "\nDespués de la inserción al inicio, el array es:" << endl;
    for (int i : inputArr) cout << i << " ";

    inputArr.insert(inputArr.end(), 35); // Inserta el elemento 35 al final del arreglo (indice, valor)
    cout << "\nDespués de la inserción al final, el array es:" << endl;
    for (int i : inputArr) cout << i << " ";

    return 0;
}
