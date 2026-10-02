public class Matriz2D {
    public static void main(String[] args) {
        // Recorrido matriz 2D
        int[][] twoDimensionalArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        System.out.println("Los elementos del array son:");
        for (int[] row : twoDimensionalArray) {
            for (int element : row) {
                System.out.print(element + " "); // mostrando los elementos de la fila separados por espacios
            }
            System.out.println(); // Ir a la siguiente linea despues de mostrar una fila
        }
    }
}
