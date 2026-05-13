namespace Lab_12_RicardoGonzalez
{
    internal class Program
    {
        /*

static void resolverActividad1()
{
Console.WriteLine("----------------------------------");
Console.WriteLine("Ejercicio1: Arreglos Bidimensionales");
Console.WriteLine("Hecho por Ricardo Gonzalez");
Console.WriteLine("----------------------------------");

//Declaracion de variables
int cantidadFilas = 3;
int cantidadColumnas = 3;
int[,] matrizNumeros = new int[cantidadColumnas, cantidadColumnas];

//Llenar la Matriz
for (int iFilas = 0; iFilas < cantidadFilas; iFilas++)
{
    for (int iColumnas = 0; iColumnas < cantidadColumnas; iColumnas++)
    {
        Console.WriteLine($"Ingrese el numero para la posicion [{iFilas},{iColumnas}]: ");
        matrizNumeros[iFilas, iColumnas] = Convert.ToInt32(Console.ReadLine());
    }
}
int sumatoria = 0;
//Muestra la matriz usando FOREACH
int contador = 0;
Console.WriteLine("Muestra la matriz utilizando FOREACH");
foreach (int item in matrizNumeros)
{
    Console.WriteLine("Valor " + contador.ToString() + ":" + item.ToString());
    contador++;
    sumatoria = sumatoria + item;

}
Console.WriteLine("");
sumatoria = 0;
//Mostrar Tabla
for (int iFilas = 0; iFilas < cantidadFilas; iFilas++)
{
    for (int iColumnas = 0; iColumnas < cantidadColumnas; iColumnas++)
    {
        Console.WriteLine(matrizNumeros[iFilas, iColumnas].ToString() + "\n");
        sumatoria += matrizNumeros[iFilas, iColumnas];

    }
    Console.WriteLine("");
}
Console.WriteLine("Sumatoria: " + sumatoria.ToString());
Console.WriteLine("Promedio: " + (sumatoria / matrizNumeros.Length).ToString());
*/
        static void resolverActividad2()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Ejercicio 2: Arreglos bidimensionales 2");
            Console.WriteLine("Hecho por: Ricardo Javier González Corado");
            Console.WriteLine("----------------------------------");

            int cantidadFilas = 0;
            int cantidadColumnas = 0;
            Random generadorAleatorio = new Random();

            Console.Write("Ingrese la cantidad de filas: ");
            cantidadFilas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese la cantidad de columnas: ");
            cantidadColumnas = Convert.ToInt32(Console.ReadLine());

            int[,] matrizNumeros = new int[cantidadFilas, cantidadColumnas];

            for (int iFilas = 0; iFilas < cantidadFilas; iFilas++)
            {
                for (int iColumnas = 0; iColumnas < cantidadColumnas; iColumnas++)
                {
                    matrizNumeros[iFilas, iColumnas] = generadorAleatorio.Next(1, 101);
                }
            }

            Console.WriteLine("\nContenido de la matriz:");
            for (int iFilas = 0; iFilas < cantidadFilas; iFilas++)
            {
                for (int iColumnas = 0; iColumnas < cantidadColumnas; iColumnas++)
                {
                    Console.Write(matrizNumeros[iFilas, iColumnas].ToString() + "\t");
                }
                Console.WriteLine();
            }

            int cantidadPares = 0;
            int cantidadImpares = 0;
            int numeroMayor = 0;
            int numeroMenor = 101;

            foreach (int item in matrizNumeros)
            {
                if (item % 2 == 0)
                {
                    cantidadPares++;
                }
                else
                {
                    cantidadImpares++;
                }

                if (item > numeroMayor)
                {
                    numeroMayor = item;
                }
                if (item < numeroMenor)
                {
                    numeroMenor = item;
                }
            }

            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("Estadísticas de la matriz:");
            Console.WriteLine("Cantidad de números pares: " + cantidadPares);
            Console.WriteLine("Cantidad de números impares: " + cantidadImpares);
            Console.WriteLine("Número mayor: " + numeroMayor);
            Console.WriteLine("Número menor: " + numeroMenor);
            Console.WriteLine("----------------------------------");

        }
        
        static void Main(string[] args)
        {

            //resolverActividad1();
            resolverActividad2();
        }

    }
}


