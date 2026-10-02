// Recorrido matriz 2D
const twoDimensionalArray = [
    [1, 2, 3],
    [4, 5, 6],
    [7, 8, 9]
];
console.log("Los elementos del array son:");
for (const row of twoDimensionalArray) {
    let linea = '';
    for (const element of row) {
        linea += element + ' '; // mostrando los elementos de la fila separados por espacios
    }
    console.log(linea); // Ir a la siguiente linea despues de mostrar una fila
}
