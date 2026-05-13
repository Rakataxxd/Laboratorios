// RICARDO JAVIER GONZALEZ CORADO 1121726
// Jose Manuel de Jesús Martinez Morales
// PROYECTO 1: Sistema de Car Wash
// Este programa simula un car wash donde se registran vehiculos,
// se agregan servicios extras y se calcula el cobro total.

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("PROYECTO 1: Sistema de Car Wash");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("Jose Manuel de Jesús Martinez Morales");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");
Console.ResetColor();

// Variables para almacenar los datos del sistema
string nombreOperador = "";   // Nombre del operador que usa el sistema
string placa = "";            // Placa del vehiculo (debe tener 6 caracteres)
int tipoVehiculo = 0;         // 1 = Sedan, 2 = Pickup/SUV
string nombreCliente = "";    // Nombre del cliente
bool ticketActivo = false;    // Indica si hay un vehiculo siendo atendido
double tarifaBase = 0;        // Costo del lavado basico (Q50 sedan, Q75 pickup)
double tarifaExtra = 0;       // Costo del lavado de llantas y rines
bool servicioExtra = false;   // Indica si se agrego el servicio de llantas
int tamanoRines = 0;          // Tamano de rines en pulgadas (12 a 22)
double totalRecaudado = 0;    // Suma de todos los cobros de la sesion
int carrosAtendidos = 0;      // Contador de vehiculos atendidos
int carrosConServicioExtra = 0; // Contador de vehiculos con servicio extra
int opcion = 0;               // Opcion seleccionada en el menu

// Se solicita el nombre del operador al iniciar el programa
Console.WriteLine("Ingrese el nombre del operador:");
nombreOperador = Console.ReadLine() ?? "";
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Bienvenido, {nombreOperador}!");
Console.ResetColor();

// Ciclo principal: el menu se repite hasta que el operador elija salir (opcion 5)
while (opcion != 5)
{
    // Mostrar menu principal con color para que se distinga
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("MENU PRINCIPAL CAR WASH DE DON JOSE");
    Console.WriteLine("1) CREAR TICKET DE ENTRADA");
    Console.WriteLine("2) LAVADO DE LLANTAS Y RINES");
    Console.WriteLine("3) CONSULTAR MONTO A COBRAR");
    Console.WriteLine("4) REGISTRAR SALIDA Y CALCULAR COBRO");
    Console.WriteLine("5) SALIR DEL PROGRAMA");
    Console.WriteLine("--------------------------------------------------------");
    Console.WriteLine("--------------------------------------------------------");
    Console.ResetColor();
    Console.WriteLine("Seleccione una opcion:");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            // === CREAR TICKET DE ENTRADA ===
            // Primero se verifica si ya hay un ticket activo
            // porque solo se puede atender un vehiculo a la vez
            if (ticketActivo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ya hay un ticket activo");
                Console.ResetColor();
            }
            else
            {
                // Solicitar placa y validar que tenga exactamente 6 caracteres sin espacios
                // Se usa un ciclo while para que el usuario lo intente de nuevo si es invalida
                Console.WriteLine("Ingrese la placa del vehiculo (6 caracteres, sin espacios):");
                placa = Console.ReadLine() ?? "";
                while (placa.Length != 6 || placa.Contains(" "))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La placa debe tener exactamente 6 caracteres y sin espacios, ingrese nuevamente");
                    Console.ResetColor();
                    placa = Console.ReadLine() ?? "";
                }

                // Solicitar tipo de vehiculo y validar que sea 1 o 2
                // Se usa while para repetir si ingresa un valor diferente
                Console.WriteLine("Tipo de vehiculo (1 = Sedan, 2 = Pickup o SUV):");
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                while (tipoVehiculo != 1 && tipoVehiculo != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tiene que ingresar 1 para Sedan o 2 para Pickup/SUV:");
                    Console.ResetColor();
                    tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el nombre del cliente:");
                nombreCliente = Console.ReadLine() ?? "";

                // Asignar tarifa base segun el tipo de vehiculo
                // Sedan cuesta Q50 y Pickup/SUV cuesta Q75
                if (tipoVehiculo == 1)
                {
                    tarifaBase = 50;
                }
                else
                {
                    tarifaBase = 75;
                }

                // Marcar el ticket como activo y reiniciar valores del servicio extra
                ticketActivo = true;
                servicioExtra = false;
                tarifaExtra = 0;
                tamanoRines = 0;

                // Mostrar resumen del ticket creado
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Ticket creado exitosamente!");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Tarifa base: Q{tarifaBase}");
                Console.WriteLine("--------------------------------------------------------");
                Console.ResetColor();
            }
            break;

        case 2:
            // === LAVADO DE LLANTAS Y RINES ===
            // Solo se puede agregar si hay un ticket activo
            if (!ticketActivo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No hay ticket activo. Primero cree un ticket de entrada.");
                Console.ResetColor();
            }
            else if (servicioExtra)
            {
                // Si ya tiene el servicio extra, se le da la opcion de cancelarlo
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("El vehiculo ya cuenta con servicio de lavado de llantas y rines.");
                Console.WriteLine($"Rines: {tamanoRines} pulgadas - Costo: Q{tarifaExtra}");
                Console.ResetColor();
                Console.WriteLine("Desea cancelar el servicio extra? (1 = Si, 2 = No):");
                int cancelar = Convert.ToInt32(Console.ReadLine());

                // Validar que ingrese 1 o 2
                while (cancelar != 1 && cancelar != 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Ingrese 1 para Si o 2 para No:");
                    Console.ResetColor();
                    cancelar = Convert.ToInt32(Console.ReadLine());
                }

                if (cancelar == 1)
                {
                    // Se cancela el servicio extra y se pone la tarifa extra en 0
                    servicioExtra = false;
                    tarifaExtra = 0;
                    tamanoRines = 0;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Servicio extra cancelado.");
                    Console.WriteLine($"Nuevo monto a cobrar: Q{tarifaBase + tarifaExtra}");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("No se realizaron cambios.");
                }
            }
            else
            {
                // Solicitar tamano de rines y validar que este entre 12 y 22
                Console.WriteLine("Ingrese el tamaño de los rines (12 a 22):");
                tamanoRines = Convert.ToInt32(Console.ReadLine());
                while (tamanoRines < 12 || tamanoRines > 22)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: El tamaño de los rines debe estar entre 12 y 22. Intente de nuevo:");
                    Console.ResetColor();
                    tamanoRines = Convert.ToInt32(Console.ReadLine());
                }

                // Calcular tarifa extra segun el rango del tamano de rines
                // De 12 a 16 pulgadas: Q30
                // De 17 a 19 pulgadas: Q40
                // De 20 a 22 pulgadas: Q60
                if (tamanoRines >= 12 && tamanoRines <= 16)
                {
                    tarifaExtra = 30;
                }
                else if (tamanoRines >= 17 && tamanoRines <= 19)
                {
                    tarifaExtra = 40;
                }
                else
                {
                    tarifaExtra = 60;
                }

                servicioExtra = true;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Servicio de lavado de llantas y rines agregado.");
                Console.WriteLine($"Rines: {tamanoRines} pulgadas - Costo extra: Q{tarifaExtra}");
                Console.WriteLine($"Nuevo monto a cobrar: Q{tarifaBase + tarifaExtra}");
                Console.ResetColor();
            }
            break;

        case 3:
            // === CONSULTAR MONTO A COBRAR ===
            // Muestra el desglose de servicios solo si hay ticket activo
            if (!ticketActivo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: No hay ticket activo.");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--- Detalle de servicios ---");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Lavado basico: Q{tarifaBase}");
                // Solo muestra el servicio extra si fue agregado
                if (servicioExtra)
                {
                    Console.WriteLine($"Lavado de llantas y rines ({tamanoRines} pulgadas): Q{tarifaExtra}");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"TOTAL A COBRAR: Q{tarifaBase + tarifaExtra}");
                Console.ResetColor();
            }
            break;

        case 4:
            // === REGISTRAR SALIDA Y CALCULAR COBRO ===
            // Solo se permite si hay un ticket activo
            if (!ticketActivo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: No hay ticket activo.");
                Console.ResetColor();
            }
            else
            {
                // Calcular el total sumando tarifa base + tarifa extra
                double totalCobro = tarifaBase + tarifaExtra;

                // Mostrar detalle final del cobro
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("--- Registrar Salida ---");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Lavado basico: Q{tarifaBase}");
                if (servicioExtra)
                {
                    Console.WriteLine($"Lavado de llantas y rines ({tamanoRines} pulgadas): Q{tarifaExtra}");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"TOTAL COBRADO: Q{totalCobro}");
                Console.ResetColor();

                // Sumar al total recaudado de toda la sesion
                totalRecaudado = totalRecaudado + totalCobro;
                // Incrementar el contador de carros atendidos
                carrosAtendidos++;
                // Si tenia servicio extra, incrementar ese contador tambien
                if (servicioExtra)
                {
                    carrosConServicioExtra++;
                }

                // Dinamica de promocion: el cliente adivina un numero del 1 al 3
                // Se genera un numero aleatorio y si coincide, gana un premio
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Adivine un numero del 1 al 3 y podria ganar un lavado gratis:");
                Console.ResetColor();
                int numeroCliente = Convert.ToInt32(Console.ReadLine());

                // Validar que el numero este entre 1 y 3
                while (numeroCliente < 1 || numeroCliente > 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ERROR: Ingrese un numero del 1 al 3:");
                    Console.ResetColor();
                    numeroCliente = Convert.ToInt32(Console.ReadLine());
                }

                // Generar numero aleatorio del 1 al 3 usando Random
                // random.Next(1, 4) genera un numero entre 1 y 3 (el 4 no se incluye)
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 4);
                Console.WriteLine($"El numero generado fue: {numeroAleatorio}");

                // Comparar: si el numero del cliente es igual al aleatorio, gana
                if (numeroCliente == numeroAleatorio)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("FELICIDADES! Gano un lavado GRATIS en su proxima visita!");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Gracias por participar. Mejor suerte la proxima vez!");
                    Console.ResetColor();
                }

                // Reiniciar todas las variables del vehiculo actual
                // para que el sistema quede listo para el siguiente vehiculo
                placa = "";
                tipoVehiculo = 0;
                nombreCliente = "";
                ticketActivo = false;
                tarifaBase = 0;
                tarifaExtra = 0;
                servicioExtra = false;
                tamanoRines = 0;

                Console.WriteLine("Datos reiniciados. Sistema listo para el siguiente vehiculo.");
            }
            break;

        case 5:
            // === SALIR DEL PROGRAMA ===
            // Mostrar reporte final con los totales de la sesion
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("REPORTE FINAL DE LA SESION");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Operador: {nombreOperador}");
            Console.WriteLine($"Total de carros atendidos: {carrosAtendidos}");
            Console.WriteLine($"Carros con servicio extra (llantas y rines): {carrosConServicioExtra}");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Total de ingresos de la sesion: Q{totalRecaudado}");
            Console.ResetColor();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Gracias por usar el sistema de Car Wash. Hasta pronto!");
            break;

        default:
            // Si el usuario ingresa un numero que no esta en el menu
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Su opcion no es valida. Seleccione una opcion del 1 al 5.");
            Console.ResetColor();
            break;
    }
}