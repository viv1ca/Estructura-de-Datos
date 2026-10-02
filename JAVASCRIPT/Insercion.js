let inputArr = [10, 15, 20, 25, 30];
console.log("Antes de la inserción, el array es:");
console.log(inputArr.join(' '));

inputArr.splice(0, 0, 5); // Inserta el elemento 5 al inicio del arreglo (indice, valor)

console.log("\nDespués de la inserción al inicio, el array es:");
console.log(inputArr.join(' '));

inputArr.splice(inputArr.length, 0, 35); // Inserta el elemento 35 al final del arreglo (indice, valor)
console.log("\nDespués de la inserción al final, el array es:");
console.log(inputArr.join(' '));
