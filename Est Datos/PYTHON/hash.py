class ShellSort:
    # Una función de utilidad para imprimir una matriz de tamaño n
    @staticmethod
    def displayArr(inputArr):
        for k in inputArr:
            print(k, end=" ")
        print()
    # Función para ordenar inputArr usando Shell Sort
    def sort(self, inputArr):
        size = len(inputArr)
        # Comience con un espacio grande y luego reduzca el espacio.
        gapSize = size // 2
        while gapSize > 0:
            # Estamos implementando una ordenación por inserción con un tamaño de espacio especificado.
            # Los primeros elementos de espacio de la matriz inputArr [0..gap-1]
            # Ya están en orden. Ahora, tenemos que seguir añadiendo
            # un elemento más hasta que la matriz completa esté ordenada
            # hasta que toda la matriz esté ordenada
            for j in range(gapSize, size):
                val = inputArr[j]
                k = j
                while k >= gapSize and inputArr[k - gapSize] > val:
                    inputArr[k] = inputArr[k - gapSize]
                    k = k - gapSize
                inputArr[k] = val
            gapSize = gapSize // 2
        return 0
if __name__ == "__main__":
    inputArr = [36, 34, 43, 11, 15, 20, 28, 45]
    print("Arreglo antes de ser ordenado: ")
    ShellSort.displayArr(inputArr)
    obj = ShellSort()
    obj.sort(inputArr)
    print("Arreglo despué de ser ordenado: ")
    ShellSort.displayArr(inputArr)