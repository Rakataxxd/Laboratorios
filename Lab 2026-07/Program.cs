// See http
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Lab 07 Ejercicio 1: Menu de opcines");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("------------------------------------------------");

int opcion = 0;
while (opcion != 4)
{ 
    Console.WriteLine("Menu de opciones");
Console.WriteLine("1. Secuencia");
Console.WriteLine("2. Nomina");
Console.WriteLine("3. Promedio");
Console.WriteLine("4. Salir");
opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("1. Secuencia");
            Console.WriteLine("Ingrese el numero final de secuencia");
            int numeroFinal = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (i <= numeroFinal)
            {
                Console.WriteLine(1.ToString());
                i++;
            }
            break;
        case 2:
            Console.WriteLine("2.Nomina");
            double totalNomina = 0;
            string respuesta = "s";
            while (respuesta == "s" || respuesta == "S")
            { 
            Console.WriteLine("Ingrese el sueldo del empleado");
            double sueldo = Convert.ToInt32(Console.ReadLine());
            totalNomina = totalNomina + sueldo;
            Console.WriteLine("Total acumulado: " + totalNomina.ToString());
            Console.WriteLine("Desea ingresar otro empleado s/n");
            respuesta = Console.ReadLine();
            }
            break;
    case 3:
            Console.WriteLine("Ingrese la cantida de estudiantes en el aula");
            double estudiantesnum;
            int n = 0;
            double nota = 0;
            double promedio;
            estudiantesnum = Convert.ToInt32(Console.ReadLine());

            while (n != estudiantesnum)
            {
                Console.WriteLine("Ingrese la nota");
                nota = Convert.ToInt32(Console.ReadLine());
                nota += nota;
                n++;
            }
            promedio = nota / estudiantesnum;
            Console.WriteLine("El promedio es igual a "+promedio);
            break;
    case 4:
        Console.WriteLine("Saliendo del programa...");
        break;

    default:
        Console.WriteLine("ERROR: No valido");
        break;
}
}