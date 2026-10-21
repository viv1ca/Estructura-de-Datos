using System;

class Matriz3D {
    static void Main(string[] args) {
        // Matriz 3D
        int[,,] threeDimensionalArray = { // Guarda 2 arreglos bidimensionales
            {
                {0, 1, 2},
                {3, 4, 5},
                {6, 7, 8}
            },
            {
                {9, 10, 11},
                {12, 13, 14},
                {15, 16, 17}
            }
        };

        Console.WriteLine("Los elementos del array son: ");
        for (int block = 0; block < threeDimensionalArray.GetLength(0); block++) { // Recorre cada arreglo bidimensional
            for (int row = 0; row < threeDimensionalArray.GetLength(1); row++) {
                for (int col = 0; col < threeDimensionalArray.GetLength(2); col++) {
                    Console.Write(threeDimensionalArray[block, row, col] + " "); // mostrando los elementos de la fila separados por espacios
                }
                Console.WriteLine(); // ir a la siguiente linea despues de mostrar una fila
            }
            Console.WriteLine();
        }
    }
}
