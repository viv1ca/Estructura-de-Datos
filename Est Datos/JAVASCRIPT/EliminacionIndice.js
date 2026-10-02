// Eliminación de un elemento en un indice específico de un arreglo
let inputArr = [5, 10, 15, 20, 25, 30];
const position = 3; // Índice del elemento a eliminar
console.log("Antes de la eliminación, el array es: ");
console.log(inputArr.join(' '));
console.log(); // Imprime una línea en blanco

// Elimina el elemento en la posición especificada
if (position >= 0 && position < inputArr.length) {
    inputArr.splice(position, 1);

    console.log("Después de la eliminación, el array es: ");
    console.log(inputArr.join(' '));
} else {
    console.log("Índice fuera de rango");
}
console.log();
