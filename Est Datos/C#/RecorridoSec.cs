using System;

class RecorridoSec {
    static void Main(string[] args) {
        // Recorrer un arreglo de forma secuencial
        int[] inputArr = {5, 10, 15, 20, 25, 30};

        Console.WriteLine("Recorrido secuencial del arreglo:");

        for (int i = 0; i < inputArr.Length; i++) {
            Console.Write(inputArr[i] + " ");
        }
    }
}
