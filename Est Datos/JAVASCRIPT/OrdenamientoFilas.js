const r = 3, c = 3;
let arr = new Array(r * c).fill(0);
// matriz inicializada y luego se le asigna un valor

const twoDArray = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
]; // almacenar elementos en un array unidimensional ordenados por filas

let k = 0;
for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        arr[k] = twoDArray[x][y];
        k = k + 1;
    }
}

console.log("Los elementos del array son: ");
for (const row of twoDArray) {
    let linea = '';
    for (const element of row) {
        linea += element + ' '; // mostrando los elementos de la fila separados por espacios
    }
    console.log(linea); // ir a la siguiente linea despues de mostrar una fila
}

// Imprimir los elementos del array unidimensional
console.log("Los elementos del array unidimensional son: ");
let salida = '';
for (let x = 0; x < r; x++) {
    for (let y = 0; y < c; y++) {
        salida += arr[x * c + y] + ' ';
    }
}
console.log(salida);
