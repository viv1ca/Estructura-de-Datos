public class SelectionSort {
    static void selection(int[] a) { // función para implementar el algoritmo de selección
        for (int i = 0; i < a.length; i++) { // recorre todo el arreglo
            int small = i; // indice del elemento más pequeño
            for (int j = i + 1; j < a.length; j++) { // encuentra el elemento más pequeño
                if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                    small = j; // actualiza el índice del elemento más pequeño
                }
            }
            int temp = a[i];
            a[i] = a[small];
            a[small] = temp; // intercambia los elementos
        }
    }

    static void printArr(int[] a) { // función para imprimir el array
        for (int i = 0; i < a.length; i++) { // recorre todo el arreglo
            System.out.print(a[i] + " "); // imprime el elemento
        }
    }

    public static void main(String[] args) {
        int[] a = {65, 26, 13, 23, 12}; // arreglo desordenado
        System.out.println("Arreglo antes de ser ordenado: ");
        printArr(a);
        selection(a);
        System.out.println("\nArreglo después de ser ordenado: ");
        selection(a);
        printArr(a);
    }
}
