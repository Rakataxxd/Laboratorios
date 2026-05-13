using Lab14_A1_Jorge_Lopez;

class OperacionesMatriz
{
    public Estudiante[,] matriz = new Estudiante[2, 3];

    public OperacionesMatriz()
    {
    }

    public void IngresarDatosMatriz()
    {
        for (int fila = 0; fila < matriz.GetLength(0); fila++)
        {
            for (int columna = 0; columna < matriz.GetLength(1); columna++)
            {
                for (string curso = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.WriteLine("Ingresa el nombre del curos");
                    Convert.ToParse
                }
                    Console.WriteLine($"Ingrese el estudiante para la posicion [{fila}][{columna}]");

                Console.WriteLine("Ingrese el nombre estudiante");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el carné estudiante");
                string carnet = Console.ReadLine();

                Estudiante estudiante = new Estudiante(nombre, carnet);
                matriz[fila, columna] = estudiante;
            }
        }
    }

    public void ConsultarEstudiante(int fila, int columna)
    {
        Console.WriteLine($"nombre: {matriz[fila, columna].nombre}");
        Console.WriteLine($"carné: {matriz[fila, columna].carnet}");
    }
}