inputArr = [5, 10, 15, 20]
print ("Antes de la eliminación, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')

del inputArr[0] #Elimina la primera posición del arreglo

print ("\nDespués de la eliminación, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')
