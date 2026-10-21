#include <iostream>
#include <vector>
using namespace std;

int main() {
    vector<int> inputArr = {5, 10, 15, 20, 25, 30};
    cout << "Antes de la eliminación, el array es:" << endl;
    for (int i : inputArr) cout << i << " ";

    inputArr.pop_back(); // Elimina el último elemento del arreglo

    cout << "\nDespués de la eliminación, el array es:" << endl;
    for (int i : inputArr) cout << i << " ";

    return 0;
}
