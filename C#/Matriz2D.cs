using System;

class Matriz2D {
    static void Main(string[] args) {
        // Recorrido matriz 2D
        int[,] twoDimensionalArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        Console.WriteLine("Los elementos del array son:");
        for (int row = 0; row < twoDimensionalArray.GetLength(0); row++) {
            for (int col = 0; col < twoDimensionalArray.GetLength(1); col++) {
                Console.Write(twoDimensionalArray[row, col] + " "); // mostrando los elementos de la fila separados por espacios
            }
            Console.WriteLine(); // Ir a la siguiente linea despues de mostrar una fila
        }
    }
}
