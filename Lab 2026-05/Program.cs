/*// Lab 05
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ejercicio 1: Nota de estudiante");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------");

int notaEstudiante = 0;
Console.WriteLine("Ingrese la nota del estudiante");
notaEstudiante=Convert.ToInt32(Console.ReadLine());

if ((notaEstudiante >= 0) && (notaEstudiante <= 100))
{
    if (notaEstudiante >= 65)
    {
        Console.WriteLine("Aprobado");
    }
    else
    {
        Console.WriteLine("Reprobado");
    }
}
else
{
    Console.WriteLine("El numero debe de estan entre los valores 0 y 100");
}
*/
/*
Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ejercicio 2: Promociones de almacen");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------");

float montoFactura = 0;
Console.WriteLine("Ingrese el monto de la Factura");
montoFactura = float.Parse(Console.ReadLine());

if ((montoFactura >= 200) && (montoFactura <=499.99))
{
    Console.WriteLine("Brindar 5% de descuento");
}
else if ((montoFactura >=500) && (montoFactura <=1999.99))
{
    Console.WriteLine("Brindar numero para la rifa");
}
else if (montoFactura>=2000)
{
    Console.WriteLine("Brindar Membresia");
}
else
{
    Console.WriteLine("Gracias por su compra");
}
*/

Console.WriteLine("-----------------------------------------------");
Console.WriteLine("Ejercicio 3: Numeración maya");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------");
int lineas;
int numeroIngresado;
int puntos;

numeroIngresado = int.Parse(Console.ReadLine());


Console.WriteLine("Ingrese el numero a convertir");


if ((numeroIngresado >= 0) && (numeroIngresado <= 19))
{
    lineas = numeroIngresado / 5;
    puntos = numeroIngresado % 5;

    Console.WriteLine($"Numero de lineas:{lineas}");
    Console.WriteLine($"Numero de lineas:{puntos}");
}