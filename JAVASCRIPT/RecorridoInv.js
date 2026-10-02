// Recorrer un arreglo de forma inversa
const inputArr = [5, 10, 15, 20, 25, 30];

console.log("Recorrido inverso del arreglo:");

let salida = '';
for (let i = inputArr.length - 1; i >= 0; i--) {
    salida += inputArr[i] + ' ';
}
console.log(salida);
