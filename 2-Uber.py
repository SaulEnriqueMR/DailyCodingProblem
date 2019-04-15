'''
This problem was asked by Uber.
Given an array of integers, return a new array such that 
each element at index i of the new array is the product of 
all the numbers in the original array except the one at i.

For example, if our input was [1, 2, 3, 4, 5], 
the expected output would be [120, 60, 40, 30, 24].

If our input was [3, 2, 1], 
the expected output would be [2, 3, 6].

Follow-up: what if you can't use division?
'''

def multiplicarArreglo(indiceEvitado, arreglo):
    resultado = 1
    for i in range(len(arreglo)):
        if i != indiceEvitado:
            resultado = resultado * arreglo[i]
    return resultado

def productoDeArreglo():
    numeroDeElementos = int(input('Número de elementos: '))

    elementos = []

    for x in range(numeroDeElementos):
        elementos.append(int(input('Introduzca elemento: ')))

    arregloMultiplicado = []

    for x in range(numeroDeElementos):
        arregloMultiplicado.append(multiplicarArreglo(x, elementos))

    return arregloMultiplicado

    

print(productoDeArreglo())