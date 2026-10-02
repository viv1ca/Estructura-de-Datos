// función para intercambiar dos elementos en el arreglo
function swap(a, j, k) {
    const temp = a[j];
    a[j] = a[k];
    a[k] = temp; // intercambia los elementos
}

// Función para hacer la partición del arreglo
function partition(a, l, h) {
    // Selecciona el elemento pivote
    const pivote = a[h];
    // j es el indice de los elementos que son menores que el
    // pivote y tambien indica la posición correcta del pivote encontrado hasta este momento
    let j = l - 1;
    // Recorre a[l...h-1] y mueve todos los elementos menores
    // al lado izquierdo del pivote.

    // Los elementos de l a j son mas pequeños después de cada iteración
    for (let k = l; k < h; k++) { // recorre el arreglo
        // Si el elemento actual es menor que el pivote
        if (a[k] < pivote) { // compara el elemento actual con el pivote
            j += 1; // incrementa el indice del elemento más pequeño
            swap(a, j, k); // intercambia los elementos
        }
    }

    // Mover el pivote despues de elementos mas pequeños y devolverlo a su posicion
    swap(a, j + 1, h); // intercambia el pivote con el elemento siguiente al ultimo elemento mas pequeño
    return j + 1; // devuelve el indice del pivote
}

// implementación de la función Quick Sort
function qckSort(a, l, h) { // función principal de Quick-sort
    if (l < h) { // si el indice izquierdo es menor que el derecho
        // pi es el indice de partición, regresa el indice del pivote
        const pi = partition(a, l, h); // particiona el arreglo

        // llamadas recurisvas para los elemento menores y mayores o iguales a los elementos
        qckSort(a, l, pi - 1); // llamada recursiva para los elementos menores que el pivote
        qckSort(a, pi + 1, h); // llamada recursiva para los elementos mayores que el pivote
    }
}

// Codigo para probar la implementación de Quick sort
const a = [10, 5, 35, 50, 15, 85, 25]; // arreglo desordenado
const size = a.length; // tamaño del arreglo
console.log("El arreglo antes de ordenarlo: ");
let salida1 = '';
for (const v of a) { // imprime el arreglo
    salida1 += v + " ";
}
console.log(salida1);

qckSort(a, 0, size - 1);

console.log("El arreglo después de ordenarlo: ");
let salida2 = '';
for (const v of a) { // imprime el arreglo ordenado
    salida2 += v + " ";
}
console.log(salida2);
