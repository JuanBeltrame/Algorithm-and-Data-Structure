internal class Program
{
    private static int[] a = new int[10];
    private static int[] b = new int[10];
    private static int[] c = new int[10];
    private static int[] sumaArr = new int[10];

    private static void InicializarArreglo(int[] arreglo, int tamanoDelArray){
        for (int i = 0; i <= tamanoDelArray ; i++){
            arreglo[i] = 0;
        }
    }

    private static void CargarArreglo(int[] arreglo, int tamanoDelArray){
        for (int i = 0; i <= tamanoDelArray ; i++){
            Console.WriteLine("Ingrese el valor para la posicion {0}", i);
            arreglo[i] = int.Parse(Console.ReadLine());
        }
    }
    private static int[] SumarArreglos(int[] arreglo1, int[] arreglo2, int[] arreglo3, int tamanoDelArray){
        for (int i = 0; i <= tamanoDelArray -1 ; i++){
            arreglo3[i] = arreglo1[i] + arreglo2[i];
        }

        return arreglo3;
    }

    private static void MostrarArreglos(int[] arreglo1, int[] arreglo2, int[] arreglo3, int tamanoDelArray){
        for (int i =0 ; i < tamanoDelArray ; i++){
            Console.WriteLine("Arreglo A:" + arreglo1[i]);
            Console.WriteLine("Arreglo A:" + arreglo2[i]);
        }
        Console.WriteLine(arreglo3);
    }
    private static void Main(string[] args)
    {
        InicializarArreglo(a, 9);
        Console.WriteLine("INGRESE LOS VALORES DEL ARREGLO A");
        CargarArreglo(a, 9);
        Console.WriteLine("INGRESE LOS VALORES DEL ARREGLO B");
        CargarArreglo(b, 10);
        CargarArreglo(c, 10);
        sumaArr = SumarArreglos(a, b, c, 10);
        MostrarArreglos(a, b, sumaArr, 10);
    }
}