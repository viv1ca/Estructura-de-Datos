// Matriz 3D
const threeDimensionalArray = [ // Guarda 2 arreglos bidimensionales
    [
        [0, 1, 2],
        [3, 4, 5],
        [6, 7, 8]
    ],
    [
        [9, 10, 11],
        [12, 13, 14],
        [15, 16, 17]
    ]
];

console.log("Los elementos del array son: ");
for (const twoDimensionalArray of threeDimensionalArray) { // Recorre cada arreglo bidimensional
    for (const row of twoDimensionalArray) {
        let linea = '';
        for (const element of row) {
            linea += element + ' '; // mostrando los elementos de la fila separados por espacios
        }
        console.log(linea); // ir a la siguiente linea despues de mostrar una fila
    }
    console.log();
}
