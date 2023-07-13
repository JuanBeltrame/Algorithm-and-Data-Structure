def ObtenerPromedio(arr):
    suma = 0
    promedio = 0
    begin = 0
    end = 30
    for i in range(begin, end):
        suma += arr[i]

    promedio = suma / end
    return promedio