public class RecorridoSec {
    public static void main(String[] args) {
        // Recorrer un arreglo de forma secuencial
        int[] inputArr = {5, 10, 15, 20, 25, 30};

        System.out.println("Recorrido secuencial del arreglo:");

        for (int i = 0; i < inputArr.length; i++) {
            System.out.print(inputArr[i] + " ");
        }
    }
}
