using System;

class MergeSort {
    static void Merge(int[] a, int l, int m, int r) {
        int a1 = m - l + 1; // Tamaño del primer array
        int a2 = r - m; // Tamaño del segundo subarray
        // crear arrays temporales
        int[] L = new int[a1];
        int[] R = new int[a2];

        // copiar datos a los arrays temporales
        for (int j = 0; j < a1; j++) {
            L[j] = a[l + j];
        }

        for (int k = 0; k < a2; k++) {
            R[k] = a[m + 1 + k];
        }

        int i = 0; // indice inicial del primer sub array
        int jj = 0; // indice inicial del segundo sub array
        int kk = l; // indice inicial del sub array mezclado

        // Mezclar los arrays temporales de nuevo en a[l...r]
        while (i < a1 && jj < a2) { // recorre ambos arrays
            if (L[i] <= R[jj]) { // comparar los elementos de ambos arrays
                a[kk] = L[i]; // copiar el elemento más pequeño al array original
                i = i + 1;
            }
            // Copiar los elementos restantes de R[] si hay alguno
            else {
                a[kk] = R[jj]; // copiar el elemento del array original
                jj = jj + 1;
            }
            kk = kk + 1; // Incrementar el indice del array original
        }
        while (i < a1) { // copiar los elementos restantes de L
            a[kk] = L[i];
            i = i + 1;
            kk = kk + 1;
        }
        while (jj < a2) { // copiar los elementos restantes del segundo array
            a[kk] = R[jj]; // copiar el elemento del array original
            jj = jj + 1; // incrementar el indice del segundo array
            kk = kk + 1; // Incrementar el indice del array original
        }
        // l es para el indice izquierdo y r es para el indice derecho del sub array de "a" a ser ordenado
    }

    static void SortMerge(int[] a, int l, int r) { // Función principal que ordena a[l...r]
        if (l < r) { // Igual que (l + r)/2, pero evita el desbordamiento para grandes valores de l y h
            int m = l + (r - l) / 2;
            // ordenar la primera y segunda mitad
            SortMerge(a, l, m); // Ordenar la primera mitad
            SortMerge(a, m + 1, r); // ordenar la segunda mitad
            Merge(a, l, m, r); // Mezclar las dos mitades
        }
    }

    // Divide el array en dos mitades, las ordena y luego las mezcla
    static void Main(string[] args) {
        int[] a = {12, 11, 13, 5, 6, 7}; // arreglo desordenado
        int s = a.Length;

        Console.WriteLine("Arreglo antes de ser ordenado: ");
        for (int j = 0; j < s; j++) {
            Console.Write(a[j] + " "); // imprime el arreglo
        }

        SortMerge(a, 0, s - 1); // llamada a la función mergeSort

        Console.WriteLine("\nArreglo después de ser ordenado: ");
        for (int j = 0; j < s; j++) {
            Console.Write(a[j] + " "); // imprime el arreglo
        }
    }
}
