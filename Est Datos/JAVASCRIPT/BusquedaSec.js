const readline = require('readline');
const rl = readline.createInterface({ input: process.stdin, output: process.stdout });

function busqSecuencial(arr, s, elemento) {
    for (let i = 0; i < s; i++) {
        if (arr[i] === elemento) { // Aplicando busqueda lineal
            return i; // Retorna el índice del elemento encontrado
        }
    }
    return -1; // Retorna -1 si el elemento no se encuentra
}

const inputArr = [5, 10, 15, 20, 25, 30];

rl.question("Ingrese el elemento a buscar: ", (answer) => {
    const searchElement = parseInt(answer);
    const size = inputArr.length;

    // operación de busqueda secuencial
    const idx = busqSecuencial(inputArr, size, searchElement);

    if (idx !== -1) {
        console.log("El elemento se encuentra en la posición: " + (idx + 1)); // Suma 1 para mostrar la posición en base 1
    } else {
        console.log("No se encuentra el elemento.");
    }

    rl.close();
});
