using System;
using System.Collections.Generic;

class EliminacionIndice {
    static void Main(string[] args) {
        // Eliminación de un elemento en un indice específico de un arreglo
        List<int> inputArr = new List<int> {5, 10, 15, 20, 25, 30};
        int position = 3; // Índice del elemento a eliminar
        Console.WriteLine("Antes de la eliminación, el array es: ");
        foreach (int i in inputArr) Console.Write(i + " ");
        Console.WriteLine(); // Imprime una línea en blanco

        // Elimina el elemento en la posición especificada
        if (position >= 0 && position < inputArr.Count) {
            inputArr.RemoveAt(position);

            Console.WriteLine("Después de la eliminación, el array es: ");
            foreach (int i in inputArr) Console.Write(i + " ");
        } else {
            Console.WriteLine("Índice fuera de rango");
        }
        Console.WriteLine();
    }
}
