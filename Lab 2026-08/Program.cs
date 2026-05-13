/*Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Lab 08 Ejercicio 1: Secuencia de numeros");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------------");

int valorfinal = 0;
Console.WriteLine("Ingrese el valor final de la secuencia");
valorfinal=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Secuencia:");
for (int i = 1; i <= valorfinal; i++)
{
    Console.WriteLine(i.ToString());
}

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Lab 08 Ejercicio 2: Secuencia de numeros");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------------");

int producto = 0;
for (int multiplicando = 1; multiplicando < 10; multiplicando++)
{
    Console.WriteLine($"Tabla del {multiplicando}");

    for (int multiplicador=1;multiplicador<=10; multiplicador++)
    {
        producto=multiplicando *multiplicador;
        Console.WriteLine($"{multiplicando} X {multiplicador} = {producto}");

    }
    Console.WriteLine();
}
*/

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("Lab 08 Ejercicio 3: Factorial");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("-----------------------------------------------------");

int factor = 0;
Console.WriteLine("Numero a sacar factorial");
factor=Convert.ToInt32(Console.ReadLine());

if (factor <= 1 && factor >= 0)
{
    Console.WriteLine("Es 1");
}
else
{
    int factorial = 1;
    for (int i =1;i<= factor;i++)
    {
        factorial *= i;
    }
    Console.WriteLine($"Factorial {factor} + es {factorial}");
}