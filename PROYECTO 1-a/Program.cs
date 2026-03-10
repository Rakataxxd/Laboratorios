// RICARDO JAVIER GONZALEZ CORADO 1121726
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("PROYECTO 1: Sistema de Car Wash");
Console.WriteLine("Hecho por: Ricardo Javier Gonzalez Corado");
Console.WriteLine("Jose Manuel de Jesús Martinez Morales");
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine("--------------------------------------------------------");

// Variables 
string nombreOperador = "";
string placa = "";
int tipoVehiculo = 0;
string nombreCliente = "";
bool ticketActivo = false;
double tarifaBase = 0;
double tarifaExtra = 0;
bool servicioExtra = false;
int tamanoRines = 0;
double totalRecaudado = 0;
int carrosAtendidos = 0;
int carrosConServicioExtra = 0;
int opcion = 0;

// Inicio
Console.WriteLine("Ingrese el nombre del operador:");
nombreOperador = Console.ReadLine() ?? "";
Console.WriteLine($"Bienvenido, {nombreOperador}!");


while (opcion != 5)
{
    // Mostrar menu de opciones
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
    Console.WriteLine("Seleccione una opcion:");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            // Crear ticket de entrada
            // No permitir crear ticket si ya existe uno activo
            if (ticketActivo)
            {
                Console.WriteLine("Ya hay un ticket activo");
            }
            else
            {
                Console.WriteLine("Ingrese la placa del vehiculo (6 caracteres, sin espacios):");
                placa = Console.ReadLine() ?? "";
                while (placa.Length != 6 || placa.Contains(" "))
                {
                    Console.WriteLine("La placa debe tener exactamente 6 caracteres y sin espacios, ingrese nuevamente");
                    placa = Console.ReadLine() ?? "";
                }

                Console.WriteLine("Tipo de vehiculo (1 = Sedan, 2 = Pickup o SUV):");
                tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                while (tipoVehiculo != 1 && tipoVehiculo != 2)
                {
                    Console.WriteLine("Tiene que ingresar 1 para Sedan o 2 para Pickup/SUV:");
                    tipoVehiculo = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Ingrese el nombre del cliente:");
                nombreCliente = Console.ReadLine() ?? "";

                if (tipoVehiculo == 1)
                {
                    tarifaBase = 50; 
                }
                else
                {
                    tarifaBase = 75; 
                }

                ticketActivo = true;
                servicioExtra = false;
                tarifaExtra = 0;
                tamanoRines = 0;
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("Ticket creado exitosamente!");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Tarifa base: Q{tarifaBase}");
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine("--------------------------------------------------------");

            }
            break;

        case 2:
            // Lavado de llantas
            if (!ticketActivo)
            {
                Console.WriteLine("No hay ticket activo. Primero cree un ticket de entrada.");
            }
            else if (servicioExtra)
            {
                // Si ya tiene servicio extra, mostrar opcion de cancelarlo
                Console.WriteLine("El vehiculo ya cuenta con servicio de lavado de llantas y rines.");
                Console.WriteLine($"Rines: {tamanoRines} pulgadas - Costo: Q{tarifaExtra}");
                Console.WriteLine("Desea cancelar el servicio extra? (1 = Si, 2 = No):");
                int cancelar = Convert.ToInt32(Console.ReadLine());
                while (cancelar != 1 && cancelar != 2)
                {
                    Console.WriteLine("ERROR: Ingrese 1 para Si o 2 para No:");
                    cancelar = Convert.ToInt32(Console.ReadLine());
                }

                if (cancelar == 1)
                {
                    // Retirar el cobro del servicio extra
                    servicioExtra = false;
                    tarifaExtra = 0;
                    tamanoRines = 0;
                    Console.WriteLine("Servicio extra cancelado.");
                    Console.WriteLine($"Nuevo monto a cobrar: Q{tarifaBase + tarifaExtra}");
                }
                else
                {
                    Console.WriteLine("No se realizaron cambios.");
                }
            }
            else
            {
                // Solicitar tamaño de rines: solo entre 12 y 22
                Console.WriteLine("Ingrese el tamaño de los rines (12 a 22):");
                tamanoRines = Convert.ToInt32(Console.ReadLine());
                while (tamanoRines < 12 || tamanoRines > 22)
                {
                    Console.WriteLine("ERROR: El tamaño de los rines debe estar entre 12 y 22. Intente de nuevo:");
                    tamanoRines = Convert.ToInt32(Console.ReadLine());
                }

                // Calcular tarifa extra segun rango de tamaño de rines
                if (tamanoRines >= 12 && tamanoRines <= 16)
                {
                    tarifaExtra = 30; // Q30
                }
                else if (tamanoRines >= 17 && tamanoRines <= 19)
                {
                    tarifaExtra = 40; // Q40
                }
                else
                {
                    tarifaExtra = 60; // Q60 (de 20 a 22)
                }

                servicioExtra = true;
                Console.WriteLine("Servicio de lavado de llantas y rines agregado.");
                Console.WriteLine($"Rines: {tamanoRines} pulgadas - Costo extra: Q{tarifaExtra}");
                Console.WriteLine($"Nuevo monto a cobrar: Q{tarifaBase + tarifaExtra}");
            }
            break;

        case 3:
            // Consultar monto a cobrar con detalle desglosado
            if (!ticketActivo)
            {
                Console.WriteLine("ERROR: No hay ticket activo.");
            }
            else
            {
                Console.WriteLine("--- Detalle de servicios ---");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Lavado basico: Q{tarifaBase}");
                // Mostrar servicio extra solo si fue agregado
                if (servicioExtra)
                {
                    Console.WriteLine($"Lavado de llantas y rines ({tamanoRines} pulgadas): Q{tarifaExtra}");
                }
                Console.WriteLine($"TOTAL A COBRAR: Q{tarifaBase + tarifaExtra}");
            }
            break;

        case 4:
            // Registrar salida y calcular cobro final
            if (!ticketActivo)
            {
                Console.WriteLine("ERROR: No hay ticket activo.");
            }
            else
            {
                double totalCobro = tarifaBase + tarifaExtra;

                // Mostrar detalle final desglosado
                Console.WriteLine("--- Registrar Salida ---");
                Console.WriteLine($"Cliente: {nombreCliente}");
                Console.WriteLine($"Placa: {placa}");
                Console.WriteLine($"Tipo de vehiculo: {(tipoVehiculo == 1 ? "Sedan" : "Pickup/SUV")}");
                Console.WriteLine($"Lavado basico: Q{tarifaBase}");
                if (servicioExtra)
                {
                    Console.WriteLine($"Lavado de llantas y rines ({tamanoRines} pulgadas): Q{tarifaExtra}");
                }
                Console.WriteLine($"TOTAL COBRADO: Q{totalCobro}");

                // Sumar al total recaudado de la sesion
                totalRecaudado = totalRecaudado + totalCobro;
                carrosAtendidos++;
                if (servicioExtra)
                {
                    carrosConServicioExtra++;
                }

                // Dinamica de promocion
                Console.WriteLine("Adivine un numero del 1 al 3 y podria ganar un lavado gratis:");
                int numeroCliente = Convert.ToInt32(Console.ReadLine());
                while (numeroCliente < 1 || numeroCliente > 3)
                {
                    Console.WriteLine("ERROR: Ingrese un numero del 1 al 3:");
                    numeroCliente = Convert.ToInt32(Console.ReadLine());
                }

                // Generar numero aleatorio del 1 al 3
                Random random = new Random();
                int numeroAleatorio = random.Next(1, 4);
                Console.WriteLine($"El numero generado fue: {numeroAleatorio}");

                // Comparar numero del cliente con el numero aleatorio
                if (numeroCliente == numeroAleatorio)
                {
                    Console.WriteLine("FELICIDADES! Gano un lavado GRATIS en su proxima visita!");
                }
                else
                {
                    Console.WriteLine("Gracias por participar. Mejor suerte la proxima vez!");
                }

                // Reiniciar datos
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
            // Salir y ,pstrar reporte
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("REPORTE FINAL DE LA SESION");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine($"Operador: {nombreOperador}");
            Console.WriteLine($"Total de carros atendidos: {carrosAtendidos}");
            Console.WriteLine($"Carros con servicio extra (llantas y rines): {carrosConServicioExtra}");
            Console.WriteLine($"Total de ingresos de la sesion: Q{totalRecaudado}");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Gracias por usar el sistema de Car Wash. Hasta pronto!");
            break;

        default:
            Console.WriteLine("Su opcion no es valida. Seleccione una opcion del 1 al 5.");
            break;
    }
}

