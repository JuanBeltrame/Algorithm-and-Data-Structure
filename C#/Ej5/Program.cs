internal class Program
{
    private static int[] a = new int[10];
    private static int[] b = new int[10];
    private static int[] c = new int[10];
    
    Program (){
        InicializarArreglo(a, 10);
        InicializarArreglo(b, 10);
        InicializarArreglo(c, 10);
    }

    private static void InicializarArreglo(int[] arreglo, int tamanoDelArray){
        for (int i = 0; i < tamanoDelArray ; i++){
            arreglo[i] = 0;
        }
    }

    private static void CargarArreglo(int[] arreglo, int tamanoDelArray){
        for (int i = 0; i < tamanoDelArray ; i++){
            Console.WriteLine("Ingrese el valor para la posicion {0}", i);
            arreglo[i] = int.Parse(Console.ReadLine());
        }
    }

    private static void Main(string[] args)
    {
        CargarArreglo(a, 10);
    }
}