using System;

class QuickSort {
    // función para intercambiar dos elementos en el arreglo
    static void Swap(int[] a, int j, int k) {
        int temp = a[j];
        a[j] = a[k];
        a[k] = temp; // intercambia los elementos
    }

    // Función para hacer la partición del arreglo
    static int Partition(int[] a, int l, int h) {
        // Selecciona el elemento pivote
        int pivote = a[h];
        // j es el indice de los elementos que son menores que el
        // pivote y tambien indica la posición correcta del pivote encontrado hasta este momento
        int j = l - 1;
        // Recorre a[l...h-1] y mueve todos los elementos menores
        // al lado izquierdo del pivote.

        // Los elementos de l a j son mas pequeños después de cada iteración
        for (int k = l; k < h; k++) { // recorre el arreglo
            // Si el elemento actual es menor que el pivote
            if (a[k] < pivote) { // compara el elemento actual con el pivote
                j += 1; // incrementa el indice del elemento más pequeño
                Swap(a, j, k); // intercambia los elementos
            }
        }

        // Mover el pivote despues de elementos mas pequeños y devolverlo a su posicion
        Swap(a, j + 1, h); // intercambia el pivote con el elemento siguiente al ultimo elemento mas pequeño
        return j + 1; // devuelve el indice del pivote
    }

    // implementación de la función Quick Sort
    static void QckSort(int[] a, int l, int h) { // función principal de Quick-sort
        if (l < h) { // si el indice izquierdo es menor que el derecho
            // pi es el indice de partición, regresa el indice del pivote
            int pi = Partition(a, l, h); // particiona el arreglo

            // llamadas recurisvas para los elemento menores y mayores o iguales a los elementos
            QckSort(a, l, pi - 1); // llamada recursiva para los elementos menores que el pivote
            QckSort(a, pi + 1, h); // llamada recursiva para los elementos mayores que el pivote
        }
    }

    // Codigo para probar la implementación de Quick sort
    static void Main(string[] args) { // punto de entrada del programa
        int[] a = {10, 5, 35, 50, 15, 85, 25}; // arreglo desordenado
        int size = a.Length; // tamaño del arreglo
        Console.WriteLine("El arreglo antes de ordenarlo: ");
        foreach (int v in a) { // imprime el arreglo
            Console.Write(v + " ");
        }
        Console.WriteLine(); // salto de linea

        QckSort(a, 0, size - 1);

        Console.WriteLine("El arreglo después de ordenarlo: ");
        foreach (int v in a) { // imprime el arreglo ordenado
            Console.Write(v + " ");
        }
    }
}
