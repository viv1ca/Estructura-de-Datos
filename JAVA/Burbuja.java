public class Burbuja {
    static void bubbleSort(int[] a) {
        int s = a.length;
        // iterando por todos los elementos del arreglo
        for (int i = 0; i < s; i++) {
            boolean isSwapped = false;
            // los ultimos i elementos ya están en su lugar correspondiente
            for (int j = 0; j < s - i - 1; j++) {
                // recorriendo por el arreglo de 0 a s-i-1
                // intercambiando si el elemento encontrado es mayor que el siguiente elemento
                if (a[j] > a[j + 1]) {
                    int temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                    isSwapped = true;
                }
            }
            if (!isSwapped) break;
        }
    }

    public static void main(String[] args) {
        int[] a = {70, 15, 2, 51, 60};
        System.out.println("Antes de ordenar los elementos del arreglo son: ");
        for (int i : a) System.out.print(i + " ");

        bubbleSort(a);

        System.out.println("\nDespués de ordenar los elementos del arreglo: ");
        for (int i : a) System.out.print(i + " ");
    }
}
