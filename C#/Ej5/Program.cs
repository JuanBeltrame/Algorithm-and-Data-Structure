internal class Program
{
    private static int[] a = new int[3];
    private static int[] b = new int[3];
    private static int[] c = new int[3];
    private static int[] sumaArr = new int[3];

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
    private static int[] SumarArreglos(int[] arreglo1, int[] arreglo2, int[] arreglo3, int tamanoDelArray){
        for (int i = 0; i < tamanoDelArray ; i++){
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
    private static void MostrarUnSoloArreglo(int[] unicoArreglo, int tamanoDelArray){
        for (int i = 0; i < tamanoDelArray ; i++){
            Console.WriteLine($"Arreglo: {unicoArreglo[i]}");
        }
    }
    private static void Main(string[] args)
    {
        InicializarArreglo(a, 3);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("INGRESE LOS VALORES DEL ARREGLO A");
        Console.ResetColor();
        CargarArreglo(a, 3);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("INGRESE LOS VALORES DEL ARREGLO B");
        Console.ResetColor();
        CargarArreglo(b, 3);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("SUMA DE LOS ARREGLOS");
        Console.ResetColor();
        sumaArr = SumarArreglos(a, b, c, 3);

        Console.WriteLine("Arreglo A");
        MostrarUnSoloArreglo(a, 3);
        Console.WriteLine("Arreglo B");
        MostrarUnSoloArreglo(b, 3);
        Console.WriteLine("Arreglo C");
        MostrarUnSoloArreglo(sumaArr, 3);
    }
}