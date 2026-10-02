import java.util.ArrayList;
import java.util.Arrays;

public class Insercion {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(10, 15, 20, 25, 30));
        System.out.println("Antes de la inserción, el array es:");
        for (int i : inputArr) System.out.print(i + " ");

        inputArr.add(0, 5); // Inserta el elemento 5 al inicio del arreglo (indice, valor)

        System.out.println("\nDespués de la inserción al inicio, el array es:");
        for (int i : inputArr) System.out.print(i + " ");

        inputArr.add(inputArr.size(), 35); // Inserta el elemento 35 al final del arreglo (indice, valor)
        System.out.println("\nDespués de la inserción al final, el array es:");
        for (int i : inputArr) System.out.print(i + " ");
    }
}
