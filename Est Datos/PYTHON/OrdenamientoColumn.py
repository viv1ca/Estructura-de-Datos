r =3; c = 3
arr = [0] *r * c
#matriz inicializada y luego se le asigna un valor

TwoDArray = [
    [1, 2, 3,],
    [4, 5, 6],
    [7, 8, 9] ]; #almacenar elementos en un array unidimensional ordenados por filas
k = 0
for y in range(c):              
    for x in range(r):
        k = y * r + x
        arr[k] = TwoDArray[x][y]
        k = k + 1
print("Los elementos del array son: ")
for row in TwoDArray:
    for element in row:
        print(element, end = " ")       #mostrando los elementos de la fila separados por espacios
    print()  #ir a la siguiente linea despues de mostrar una fila
#Imprimir los elementos del array unidimensional
print("Los elementos del array unidimensional son: ")
for x in range(r):
    for y in range(c):
        print(arr[x * c + y] , end = " ")  
   
    
               