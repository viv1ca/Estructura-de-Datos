#Busqueda binaria en arreglo con elementos ordenados
def busqBinaria(arr, l, h, elemento):
    while l <= h:
        mid = l + (h - l) // 2  # Encuentra el índice medio

        # Verifica si el elemento está presente en el medio
        if arr[mid] == elemento:
            return mid  # Retorna el índice del elemento encontrado

        # Si el elemento es mayor, ignora la mitad izquierda
        elif arr[mid] < elemento:
            l = mid + 1

        # Si el elemento es menor, ignora la mitad derecha
        else:
            h = mid - 1
        #Si el control llega hasta aquí, el elemento no está presente en el arreglo
    return -1  # Retorna -1 si el elemento no se encuentra
if __name__ == "__main__":
    inputArr = [5, 10, 15, 20, 25, 30, 35, 40, 45, 50]
    buscarelemento = 20
    s = len(inputArr)

    #operación de busqueda binaria
    idx = busqBinaria(inputArr, 0, s - 1, buscarelemento)
    
    if idx != -1:
        print("El elemento se encuentra en la posición: " +str(idx +1 ))  # Suma 1 para mostrar la posición en base 1
    else:
        print("No se encuentra el elemento.")