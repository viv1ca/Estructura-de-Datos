import java.util.Scanner;

public class BusquedaSec {
    static int busqSecuencial(int[] arr, int s, int elemento) {
        for (int i = 0; i < s; i++) {
            if (arr[i] == elemento) { // Aplicando busqueda lineal
                return i; // Retorna el índice del elemento encontrado
            }
        }
        return -1; // Retorna -1 si el elemento no se encuentra
    }

    public static void main(String[] args) {
        int[] inputArr = {5, 10, 15, 20, 25, 30};
        Scanner sc = new Scanner(System.in);
        System.out.print("Ingrese el elemento a buscar: ");
        int searchElement = sc.nextInt();
        int size = inputArr.length;

        // operación de busqueda secuencial
        int idx = busqSecuencial(inputArr, size, searchElement);

        if (idx != -1) {
            System.out.println("El elemento se encuentra en la posición: " + (idx + 1)); // Suma 1 para mostrar la posición en base 1
        } else {
            System.out.println("No se encuentra el elemento.");
        }
        sc.close();
    }
}
