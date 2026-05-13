Console.WriteLine("------------------------------");
Console.WriteLine("Ejercicio 1: Cuenta bancaria");
Console.WriteLine("Hecho por: Ricardo Gonzalez       Carnet: 1121726");
Console.WriteLine("------------------------------");
//Declaracion de variables
int numerocuenta = 0;
double saldo = 0;
double saldoDepositar, SaldoRetirar;
int opcion = 0;

Console.WriteLine("Ingrese el saldo inicial");
saldo = Convert.ToDouble(Console.ReadLine());

Random random = new Random();
numerocuenta=random.Next(10000,99999+1);
Console.WriteLine($"La cuenta ha sido creada, su numero de cuenta es {numerocuenta}");

Console.WriteLine("Menu de opciones");
Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Depositar");
Console.WriteLine("3. Retirar");
Console.WriteLine("Salir");
opcion = Convert.ToInt32(Console.ReadLine());
//Estructura de repeticion
while(opcion !=4)
{
    opcion = Convert.ToInt32(Console.ReadLine()); 

    //Estructura de seleccion multiple
    switch (opcion)
{
    case 1:
        //Consultar Saldo
        Console.WriteLine("Su saldo es de" + saldo);

        break;

    case 2:
        //Depositar
        Console.WriteLine("Ingrese monto a depositar");
        saldoDepositar = Convert.ToInt32(Console.ReadLine());
        if (saldoDepositar > 0)
        {
            saldo = saldo + saldoDepositar;
            Console.WriteLine($"El saldo total es:{saldo}");
        }
        else
        {
            Console.WriteLine("El monto a depositar debe de ser mayor a 0");
        }
        break;
    case 3:
        //Retirar

        break;
    case 4:
        //Consultar Saldo
        Console.WriteLine("Gracias por usar el programa");
        break;
    default:
        Console.WriteLine("Ingrese una opcion valida");
        break;
    }
}