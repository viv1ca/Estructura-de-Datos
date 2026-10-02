using System;

class BusquedaBinaria {
    static int BusqBinaria(int[] arr, int l, int h, int elemento) {
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

    static void Main(string[] args) {
        int[] inputArr = {5, 10, 15, 20, 25, 30, 35, 40, 45, 50};
        int buscarElemento = 20;
        int s = inputArr.Length;

        // operación de busqueda binaria
        int idx = BusqBinaria(inputArr, 0, s - 1, buscarElemento);

        if (idx != -1) {
            Console.WriteLine("El elemento se encuentra en la posición: " + (idx + 1)); // Suma 1 para mostrar la posición en base 1
        } else {
            Console.WriteLine("No se encuentra el elemento.");
        }
    }
}
