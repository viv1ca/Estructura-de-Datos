function selection(a) { // función para implementar el algoritmo de selección
    for (let i = 0; i < a.length; i++) { // recorre todo el arreglo
        let small = i; // indice del elemento más pequeño
        for (let j = i + 1; j < a.length; j++) { // encuentra el elemento más pequeño
            if (a[small] > a[j]) { // compara el elemento más pequeño con el siguiente elemento
                small = j; // actualiza el índice del elemento más pequeño
            }
        }
        [a[i], a[small]] = [a[small], a[i]]; // intercambia los elementos
    }
}

function printArr(a) { // función para imprimir el array
    let salida = '';
    for (let i = 0; i < a.length; i++) { // recorre todo el arreglo
        salida += a[i] + " "; // imprime el elemento
    }
    console.log(salida);
}

const a = [65, 26, 13, 23, 12]; // arreglo desordenado
console.log("Arreglo antes de ser ordenado: ");
printArr(a);
selection(a);
console.log("\nArreglo después de ser ordenado: ");
selection(a);
printArr(a);
