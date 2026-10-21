using System;
using System.Collections.Generic;

class EliminacionFinal {
    static void Main(string[] args) {
        List<int> inputArr = new List<int> {5, 10, 15, 20, 25, 30};
        Console.WriteLine("Antes de la eliminación, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");

        inputArr.RemoveAt(inputArr.Count - 1); // Elimina el último elemento del arreglo

        Console.WriteLine("\nDespués de la eliminación, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");
    }
}
