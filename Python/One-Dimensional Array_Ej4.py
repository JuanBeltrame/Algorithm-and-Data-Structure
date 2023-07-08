def IncializarArreglo(arreglo, tam):
    for i in range(0, tam):
        arreglo[i] = 0

def CargarArreglo(arreglo, tam):
    for i in range(0, tam):
        arreglo[i] = str((input("Ingrese un caracter:")))

def MostrarArreglo(arreglo, tam):
    for i in range (0, tam):
        if arreglo[i] != '*':
            print(arreglo[i])
            print("Se ingreso en la posicion: ", i)


# Programa Principal
T = 3
A = [0] * T

IncializarArreglo(A, T)
CargarArreglo(A, T)
MostrarArreglo(A, T)
