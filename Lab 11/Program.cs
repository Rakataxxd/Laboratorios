namespace Lab11_Ricardo_Gonzalez
{
    internal class Program
    {
        static void resolverActividad()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Lab 11 Ejercicio 1: Arreglos Unidimensionales 1");
            Console.WriteLine("Hecho por: Ricardo Javier González Corado");
            Console.WriteLine("------------------------------------------------------");

            int[] vectorNumeros = new int[5];
            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                Console.WriteLine($"Ingrese numero para la posicion [{i}] del vector");
                vectorNumeros[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sumatoria = 0;
            Console.WriteLine("El contenido del vector es:");
            for (int i = 0; i < vectorNumeros.Length; i++)
            {
                Console.WriteLine(vectorNumeros[i].ToString());
                sumatoria = sumatoria + vectorNumeros[i];
            }
            double promedio = sumatoria / (double)vectorNumeros.Length;
            Console.WriteLine("La sumatoria es: " + sumatoria.ToString());
            Console.WriteLine("El promedio es: " + promedio.ToString());
        }

        static void resolverActividad2()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Lab 11 Ejercicio 2: Arreglos Unidimensionales 2");
            Console.WriteLine("Hecho por: Ricardo Javier González Corado");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Ingrese el codigo de la casa (Letra-Numero)");
            string codigoCasa = Console.ReadLine() ?? "";

            string[] vectorSeparacion = codigoCasa.Split("-");

            if (vectorSeparacion.Length < 2)
            {
                Console.WriteLine("Formato invalido. Debe ingresar en formato Letra-Numero (ej: A-5)");
                return;
            }

            string manzana = vectorSeparacion[0];
            string numeroCasa = vectorSeparacion[1];

            Console.WriteLine($"El sector es {manzana} y el numero de casa es {numeroCasa}");
        }

        static void resolverActividad3()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Lab 11 Ejercicio 3: Arreglo con numeros aleatorios");
            Console.WriteLine("Hecho por: Ricardo Javier González Corado - 1121726");
            Console.WriteLine("------------------------------------------------------");

            Random rnd = new Random();
            int[] vectorAleatorio = new int[10];
            for (int i = 0; i < vectorAleatorio.Length; i++)
            {
                vectorAleatorio[i] = rnd.Next(1, 6);
            }

            Console.WriteLine("El contenido del arreglo es:");
            for (int i = 0; i < vectorAleatorio.Length; i++)
            {
                Console.WriteLine($"[{i}] = " + vectorAleatorio[i].ToString());
            }

            int sumatoriaImpares = 0;
            for (int i = 0; i < vectorAleatorio.Length; i++)
            {
                if (i % 2 != 0)
                {
                    sumatoriaImpares = sumatoriaImpares + vectorAleatorio[i];
                }
            }
            Console.WriteLine("La sumatoria de posiciones impares es: " + sumatoriaImpares.ToString());
        }

        static void Main(string[] args)
        {
            //resolverActividad();
            //resolverActividad2();
            resolverActividad3();
        }
    }
}