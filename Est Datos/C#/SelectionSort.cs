using System;

class SelectionSort {
    static void Selection(int[] a) { // función para implementar el algoritmo de selección
        for (int i = 0; i < a.Length; i++) { // recorre todo el arreglo
            int small = i; // indice del elemento más pequeño
            for (int j = i + 1; j < a.Length; j++) { // encuentra el elemento más pequeño
                if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                    small = j; // actualiza el índice del elemento más pequeño
                }
            }
            int temp = a[i];
            a[i] = a[small];
            a[small] = temp; // intercambia los elementos
        }
    }

    static void PrintArr(int[] a) { // función para imprimir el array
        for (int i = 0; i < a.Length; i++) { // recorre todo el arreglo
            Console.Write(a[i] + " "); // imprime el elemento
        }
    }

    static void Main(string[] args) {
        int[] a = {65, 26, 13, 23, 12}; // arreglo desordenado
        Console.WriteLine("Arreglo antes de ser ordenado: ");
        PrintArr(a);
        Selection(a);
        Console.WriteLine("\nArreglo después de ser ordenado: ");
        Selection(a);
        PrintArr(a);
    }
}
