function merge(a, l, m, r) {
    const a1 = m - l + 1; // Tamaño del primer array
    const a2 = r - m; // Tamaño del segundo subarray
    // crear arrays temporales
    const L = new Array(a1).fill(0);
    const R = new Array(a2).fill(0);

    // copiar datos a los arrays temporales
    for (let j = 0; j < a1; j++) {
        L[j] = a[l + j];
    }

    for (let k = 0; k < a2; k++) {
        R[k] = a[m + 1 + k];
    }

    let i = 0; // indice inicial del primer sub array
    let j = 0; // indice inicial del segundo sub array
    let k = l; // indice inicial del sub array mezclado

    // Mezclar los arrays temporales de nuevo en a[l...r]
    while (i < a1 && j < a2) { // recorre ambos arrays
        if (L[i] <= R[j]) { // comparar los elementos de ambos arrays
            a[k] = L[i]; // copiar el elemento más pequeño al array original
            i = i + 1;
        }
        // Copiar los elementos restantes de R[] si hay alguno
        else {
            a[k] = R[j]; // copiar el elemento del array original
            j = j + 1;
        }
        k = k + 1; // Incrementar el indice del array original
    }
    while (i < a1) { // copiar los elementos restantes de L
        a[k] = L[i];
        i = i + 1;
        k = k + 1;
    }
    while (j < a2) { // copiar los elementos restantes del segundo array
        a[k] = R[j]; // copiar el elemento del array original
        j = j + 1; // incrementar el indice del segundo array
        k = k + 1; // Incrementar el indice del array original
    }
    // l es para el indice izquierdo y r es para el indice derecho del sub array de "a" a ser ordenado
}

function mergeSort(a, l, r) { // Función principal que ordena a[l...r]
    if (l < r) { // Igual que (l + r)/2, pero evita el desbordamiento para grandes valores de l y h
        const m = l + Math.floor((r - l) / 2);
        // ordenar la primera y segunda mitad
        mergeSort(a, l, m); // Ordenar la primera mitad
        mergeSort(a, m + 1, r); // ordenar la segunda mitad
        merge(a, l, m, r); // Mezclar las dos mitades
    }
}

// Divide el array en dos mitades, las ordena y luego las mezcla
const a = [12, 11, 13, 5, 6, 7]; // arreglo desordenado
const s = a.length;

console.log("Arreglo antes de ser ordenado: ");
let salida1 = '';
for (let j = 0; j < s; j++) {
    salida1 += a[j] + " "; // imprime el arreglo
}
console.log(salida1);

mergeSort(a, 0, s - 1); // llamada a la función mergeSort

console.log("\nArreglo después de ser ordenado: ");
let salida2 = '';
for (let j = 0; j < s; j++) {
    salida2 += a[j] + " "; // imprime el arreglo
}
console.log(salida2);
