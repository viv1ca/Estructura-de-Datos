public class RecorridoInv {
    public static void main(String[] args) {
        // Recorrer un arreglo de forma inversa
        int[] inputArr = {5, 10, 15, 20, 25, 30};

        System.out.println("Recorrido inverso del arreglo:");

        for (int i = inputArr.length - 1; i >= 0; i--) {
            System.out.print(inputArr[i] + " ");
        }
    }
}
