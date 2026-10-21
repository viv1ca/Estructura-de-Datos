using System;
using System.Collections.Generic;

class EliminacionInicio {
    static void Main(string[] args) {
        List<int> inputArr = new List<int> {5, 10, 15, 20};
        Console.WriteLine("Antes de la eliminación, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");

        inputArr.RemoveAt(0);

        Console.WriteLine("\nDespués de la eliminación, el array es:");
        foreach (int i in inputArr) Console.Write(i + " ");
    }
}
