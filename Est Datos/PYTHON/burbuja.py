def bubblesort(a):
    s = len(a)
    #iterando por todos los elementos del arreglo
    for i in range(s):
        isSwapped = False
        #los ultimos i elementos ya están en su lugar correspondiente
        for i in range(0, s-i-1):
            #Recorriendo por el arreglo de 0 a s-i-1
            #intercambiando si el elemento encontrado es mayor que el siguiente elemento
            if a[i] > a[i+1]:
                a[i], a[i+1] = a[i+1], a[i]
                isSwapped = True
        if (isSwapped == False):
            break
#Código para imprimir el arreglo
if __name__ == "__main__":
    a = [70, 15, 2, 51, 60]
    print("Antes de ordenar los elementos del arreglo son: ")
    for i in a:
        print(i, end = " ")

    bubblesort(a)
    print("\nDespués de ordenar los elementos del arreglo: ")
    for i in range(len(a)):
        print (a[i], end = " ")    