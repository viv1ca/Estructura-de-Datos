using System;

class Burbuja {
    static void BubbleSort(int[] a) {
        int s = a.Length;
        // iterando por todos los elementos del arreglo
        for (int i = 0; i < s; i++) {
            bool isSwapped = false;
            // los ultimos i elementos ya están en su lugar correspondiente
            for (int j = 0; j < s - i - 1; j++) {
                // recorriendo por el arreglo de 0 a s-i-1
                // intercambiando si el elemento encontrado es mayor que el siguiente elemento
                if (a[j] > a[j + 1]) {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    isSwapped = true;
                }
            }
            if (!isSwapped) break;
        }
    }

    static void Main(string[] args) {
        int[] a = {70, 15, 2, 51, 60};
        Console.WriteLine("Antes de ordenar los elementos del arreglo son: ");
        foreach (int i in a) Console.Write(i + " ");

        BubbleSort(a);

        Console.WriteLine("\nDespués de ordenar los elementos del arreglo: ");
        foreach (int i in a) Console.Write(i + " ");
    }
}
