#Matriz 3D
ThreeDimensionalArray = [ #Guarda 2 arreglos bidimensionales
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

]

print("Los elementos del array son: ")
for Two_dimensional_array in ThreeDimensionalArray: #Recorre cada arreglo bidimensional
    for row in Two_dimensional_array:
        for element in row:
            print(element, end = " ")       #mostrando los elementos de la fila separados por espacios
        print()  #ir a la siguiente linea despues de mostrar una fila    
    print() 