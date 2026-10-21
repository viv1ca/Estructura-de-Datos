public class Matriz3D {
    public static void main(String[] args) {
        // Matriz 3D
        int[][][] threeDimensionalArray = { // Guarda 2 arreglos bidimensionales
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

        System.out.println("Los elementos del array son: ");
        for (int[][] twoDimensionalArray : threeDimensionalArray) { // Recorre cada arreglo bidimensional
            for (int[] row : twoDimensionalArray) {
                for (int element : row) {
                    System.out.print(element + " "); // mostrando los elementos de la fila separados por espacios
                }
                System.out.println(); // ir a la siguiente linea despues de mostrar una fila
            }
            System.out.println();
        }
    }
}
