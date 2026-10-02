function insertionSort(a) {
    for (let i = 1; i < a.length; i++) {
        let temp = a[i];
        let j = i - 1;
        while (j >= 0 && temp < a[j]) {
            a[j + 1] = a[j];
            j = j - 1;
            a[j + 1] = temp;
        }
    }
}

function printArr(a) {
    console.log(a.join(' '));
}

const a = [70, 15, 2, 51, 60];
console.log("Antes de ordenar los elementos del arreglo: ");
printArr(a);
insertionSort(a);
console.log("\nDespués de ordenar los elementos del arreglo: ");
printArr(a);
