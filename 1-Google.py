'''
This problem was recently asked by Google.
Given a list of numbers and a number k, return whether any two numbers from the list add up to k.
For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.
Bonus: Can you do this in one pass?
'''

def buscarSuma():

    numeroDeElementos = int(input('Número de elementos: '))

    elementos = []

    for x in range(numeroDeElementos):
        elementos.append(int(input('Introduzca elemento: ')))

    sumaBuscada = int(input('Número de suma buscada: '))

    for elemento in elementos:
        buscado = sumaBuscada - elemento
        if buscado in elementos:
            return True

    return False

print(buscarSuma())