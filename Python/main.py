# Practica 3 - Unidimensional - Ejercicio 03

# Declarativa
"""
TYPE
    arreglo = array [0..24] of integer
VAR
    suma: integer
    lista: arreglo
    T: int
"""
def Cargar (l, TAM):
    global T
    for i in range(0, TAM):
        l[i] = int(input(str(i+1) + ". Ingreso: "))


def SumaPos(x, TAM):
    global T
    acum = 0
    for i in range (0, TAM):
        if x[i] > 0 :
            acum = acum + x[i]
    return acum




# Programa Principal
T = 3 # Constante para el tamano del arreglo, aunque pyton no maneja el concepto de constante # Las constantes se declaran en Mayusculas
lista = [0]*T # La lista se representa por medio de corchetes, A una lista que va a tener de valor 0, la voy a reproducir 25 veces  Esto significa que adentro de lista habra 3 casilleros empezando en el indice 0 y adentro tendra todos valores 0
Cargar(lista, T)
suma = SumaPos(lista[:], T)
print('La suma de los numeros positivos ingresados es: ', suma)




