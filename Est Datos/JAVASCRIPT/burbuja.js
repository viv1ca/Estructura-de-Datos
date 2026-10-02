function bubbleSort(a) {
    const s = a.length;
    // iterando por todos los elementos del arreglo
    for (let i = 0; i < s; i++) {
        let isSwapped = false;
        // los ultimos i elementos ya están en su lugar correspondiente
        for (let j = 0; j < s - i - 1; j++) {
            // recorriendo por el arreglo de 0 a s-i-1
            // intercambiando si el elemento encontrado es mayor que el siguiente elemento
            if (a[j] > a[j + 1]) {
                [a[j], a[j + 1]] = [a[j + 1], a[j]];
                isSwapped = true;
            }
        }
        if (!isSwapped) break;
    }
}

const a = [70, 15, 2, 51, 60];
console.log("Antes de ordenar los elementos del arreglo son: ");
console.log(a.join(" "));

bubbleSort(a);

console.log("\nDespués de ordenar los elementos del arreglo: ");
console.log(a.join(" "));
