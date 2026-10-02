#Busqueda secuencial de elementos en un arreglo
def busqSecuencial(arr, s, elemento):
    for i in range(s):
        if (arr[i] == elemento): #Aplicando busqueda lineal
            return i  # Retorna el índice del elemento encontrado
        
    return -1  # Retorna -1 si el elemento no se encuentra

if __name__ == "__main__":
    inputArr = [5, 10, 15, 20, 25, 30]
    searchElement = int(input("Ingrese el elemento a buscar: "))
    size = len(inputArr)

    #operación de busqueda secuencial
    idx = busqSecuencial(inputArr, size, searchElement)
    
    if idx != -1:
        print("El elemento se encuentra en la posición: " +str(idx +1 ))  # Suma 1 para mostrar la posición en base 1
    else:
        print("No se encuentra el elemento.")


