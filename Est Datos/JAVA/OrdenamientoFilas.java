public class OrdenamientoFilas {
    public static void main(String[] args) {
        int r = 3, c = 3;
        int[] arr = new int[r * c];
        // matriz inicializada y luego se le asigna un valor

        int[][] twoDArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        }; // almacenar elementos en un array unidimensional ordenados por filas

        int k = 0;
        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                arr[k] = twoDArray[x][y];
                k = k + 1;
            }
        }

        System.out.println("Los elementos del array son: ");
        for (int[] row : twoDArray) {
            for (int element : row) {
                System.out.print(element + " "); // mostrando los elementos de la fila separados por espacios
            }
            System.out.println(); // ir a la siguiente linea despues de mostrar una fila
        }

        // Imprimir los elementos del array unidimensional
        System.out.println("Los elementos del array unidimensional son: ");
        for (int x = 0; x < r; x++) {
            for (int y = 0; y < c; y++) {
                System.out.print(arr[x * c + y] + " ");
            }
        }
    }
}
