def selection(a): #función para implementar el algortitmo de seleccion
    for i in range(len(a)): #recorre todo el arreglo
        small = i #indice del elemento más pequeño
        for j in range(i + 1, len(a)): #encuentra el elemento más pequeño
            if a[small] > a[j]: #compara el elemento más pequeño con el siguiente elemento
                small = j #actualiza el índice del elemento más pequeño
        a[i], a[small] = a[small], a[i] #intercambia los elementos
def printArr(a): #función para imprimir el array
    for i in range(len(a)): #recorre todo el arreglo
        print (a[i], end = " ") #imprime el elemento
a = [65, 26, 13, 23, 12] #arreglo desordenado
print("Arreglo antes de ser ordenado: ")
printArr(a)
selection(a)
print("\nArreglo después de ser ordenado: ") 
selection(a)
printArr(a)       