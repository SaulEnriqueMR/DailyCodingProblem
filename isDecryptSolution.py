def isCryptSolution(crypt, solution):
    soluciones = {}
    conversiones = []
    for i in solution:
        soluciones[i[0]] = i[1]
    for cadenaAEvaluar in crypt:
        if soluciones[cadenaAEvaluar[0]] == '0' and len(cadenaAEvaluar) > 1 :
            return False
        suma = ''
        for caracter in cadenaAEvaluar:
            suma += soluciones[caracter]
        conversiones.append(suma)
    if int(conversiones[0]) + int(conversiones[1]) == int(conversiones[2]):
        return True
    return False