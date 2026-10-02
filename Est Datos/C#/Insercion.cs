using System;
using System.Collections.Generic;

class Insercion {
    static void Main(string[] args) {
        List<int> inputArr = new List<int> {10, 15, 20, 25, 30};
        Console.WriteLine("Antes de la inserción, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");

        inputArr.Insert(0, 5); // Inserta el elemento 5 al inicio del arreglo (indice, valor)

        Console.WriteLine("\nDespués de la inserción al inicio, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");

        inputArr.Insert(inputArr.Count, 35); // Inserta el elemento 35 al final del arreglo (indice, valor)
        Console.WriteLine("\nDespués de la inserción al final, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");
    }
}
