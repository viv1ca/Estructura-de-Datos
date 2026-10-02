import java.util.ArrayList;
import java.util.Arrays;

public class EliminacionFinal {
    public static void main(String[] args) {
        ArrayList<Integer> inputArr = new ArrayList<>(Arrays.asList(5, 10, 15, 20, 25, 30));
        System.out.println("Antes de la eliminación, el array es:");
        for (int i : inputArr) System.out.print(i + " ");

        inputArr.remove(inputArr.size() - 1); // Elimina el último elemento del arreglo

        System.out.println("\nDespués de la eliminación, el array es:");
        for (int i : inputArr) System.out.print(i + " ");
    }
}
