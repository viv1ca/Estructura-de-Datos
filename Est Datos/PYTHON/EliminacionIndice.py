# Eliminación de un elemento en un indice específico de un arreglo
inputArr = [5, 10, 15, 20, 25, 30]
position = 3  # Índice del elemento a eliminar
print ("Antes de la eliminación, el array es: ")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')
print()  # Imprime una línea en blanco

# Elimina el elemento en la posición especificada
if 0 <= position < len(inputArr):
    inputArr.pop(position)

    print("Después de la eliminación, el array es: ")
    for i in range(len(inputArr)):
        print(inputArr[i], end=' ')

else:
    print("Índice fuera de rango")
print()
