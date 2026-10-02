function busqBinaria(arr, l, h, elemento) {
    while (l <= h) {
        const mid = l + Math.floor((h - l) / 2); // Encuentra el índice medio

        // Verifica si el elemento está presente en el medio
        if (arr[mid] === elemento) {
            return mid; // Retorna el índice del elemento encontrado
        }
        // Si el elemento es mayor, ignora la mitad izquierda
        else if (arr[mid] < elemento) {
            l = mid + 1;
        }
        // Si el elemento es menor, ignora la mitad derecha
        else {
            h = mid - 1;
        }
    }
    // Si el control llega hasta aquí, el elemento no está presente en el arreglo
    return -1; // Retorna -1 si el elemento no se encuentra
}

const inputArr = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50];
const buscarElemento = 20;
const s = inputArr.length;

// operación de busqueda binaria
const idx = busqBinaria(inputArr, 0, s - 1, buscarElemento);

if (idx !== -1) {
    console.log("El elemento se encuentra en la posición: " + (idx + 1)); // Suma 1 para mostrar la posición en base 1
} else {
    console.log("No se encuentra el elemento.");
}
