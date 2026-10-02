using System;

class BusquedaSec {
    static int BusqSecuencial(int[] arr, int s, int elemento) {
        for (int i = 0; i < s; i++) {
            if (arr[i] == elemento) { // Aplicando busqueda lineal
                return i; // Retorna el índice del elemento encontrado
            }
        }
        return -1; // Retorna -1 si el elemento no se encuentra
    }

    static void Main(string[] args) {
        int[] inputArr = {5, 10, 15, 20, 25, 30};
        Console.Write("Ingrese el elemento a buscar: ");
        int searchElement = int.Parse(Console.ReadLine());
        int size = inputArr.Length;

        // operación de busqueda secuencial
        int idx = BusqSecuencial(inputArr, size, searchElement);

        if (idx != -1) {
            Console.WriteLine("El elemento se encuentra en la posición: " + (idx + 1)); // Suma 1 para mostrar la posición en base 1
        } else {
            Console.WriteLine("No se encuentra el elemento.");
        }
    }
}
