using System;

class RecorridoInv {
    static void Main(string[] args) {
        // Recorrer un arreglo de forma inversa
        int[] inputArr = {5, 10, 15, 20, 25, 30};

        Console.WriteLine("Recorrido inverso del arreglo:");

        for (int i = inputArr.Length - 1; i >= 0; i--) {
            Console.Write(inputArr[i] + " ");
        }
    }
}
