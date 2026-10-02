// Recorrer un arreglo de forma secuencial
const inputArr = [5, 10, 15, 20, 25, 30];

console.log("Recorrido secuencial del arreglo:");

let salida = '';
for (let i = 0; i < inputArr.length; i++) {
    salida += inputArr[i] + ' ';
}
console.log(salida);
