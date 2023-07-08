def Carga(L, TAM):
    for i in range(0,TAM):
        L[i] = int(input(str(i+1)+". Ingrese un nro.: "))

def SUMAPOS(X,TAM):
    acum = 0 
    for i in range (0,TAM):
        if X[i] > 0:
            acum = acum + X[i]
    return acum


#Programa Principal
T = 3
lista = [0]*T
Carga(lista, T)
suma = SUMAPOS(lista[:], T)
print("La suma de los nros. positivos es: ", suma)