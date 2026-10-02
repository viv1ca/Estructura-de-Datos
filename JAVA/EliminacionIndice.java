import java.util.ArrayList;
import java.util.Arrays;

public class EliminacionIndice {
    public static void main(String[] args) {
        // Eliminación de un elemento en un indice específico de un arreglo
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(5, 10, 15, 20, 25, 30));
        int position = 3; // Índice del elemento a eliminar
        System.out.println("Antes de la eliminación, el array es: ");
        for (int i : inputArr) System.out.print(i + " ");
        System.out.println(); // Imprime una línea en blanco

        // Elimina el elemento en la posición especificada
        if (position >= 0 && position < inputArr.size()) {
            inputArr.remove(position);

            System.out.println("Después de la eliminación, el array es: ");
            for (int i : inputArr) System.out.print(i + " ");
        } else {
            System.out.println("Índice fuera de rango");
        }
        System.out.println();
    }
}
