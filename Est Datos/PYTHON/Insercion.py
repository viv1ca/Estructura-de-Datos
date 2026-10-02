inputArr = [10, 15, 20, 25, 30,]
print ("Antes de la inserción, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')


inputArr.insert(0,5)  # Inserta el elemento 5 al inicio del arreglo (indice , valor)

print ("\nDespués de la inserción al inicio, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')

inputArr.insert(len(inputArr),35)  # Inserta el elemento 35 al final del arreglo (indice , valor)
print ("\nDespués de la inserción al final, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')