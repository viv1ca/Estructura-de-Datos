inputArr = [5, 10, 15, 20, 25, 30]
print ("Antes de la eliminación, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')

del inputArr[-1]  # Elimina el último elemento del arreglo

print ("\nDespués de la eliminación, el array es:")
for i in range(len(inputArr)):
    print(inputArr[i], end=' ')